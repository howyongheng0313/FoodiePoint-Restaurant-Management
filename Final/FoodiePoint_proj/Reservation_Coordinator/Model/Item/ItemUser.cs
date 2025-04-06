using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_Coordinator.Model.Item
{
    public class ItemUser
    {
        public static ItemUser Login(string usrnm, string paswd)
        {
            var login_cmd = new SqlCommand(
                $"SELECT * FROM {DataHelper.UserT} " +
                "WHERE [Username] = @usrnm AND [Password] = @paswd", DataHelper.conn);
            login_cmd.Parameters.AddWithValue("@usrnm", usrnm);
            login_cmd.Parameters.AddWithValue("@paswd", paswd);

            DataHelper.conn.Open();
            SqlDataReader reader = login_cmd.ExecuteReader();

            if (reader.Read())
            {
                var user =  new ItemUser(
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6));
                DataHelper.conn.Close();
                return user;
            }
            else
            {
                DataHelper.conn.Close();
                return null;
            }
        }

        public static bool ExistUsername(string usrnm)
        {
            var exist_cmd = new SqlCommand(
                $"SELECT [Username] FROM {DataHelper.UserT} " +
                $"WHERE [Username] = @usrnm", DataHelper.conn);
            exist_cmd.Parameters.AddWithValue("@usrnm", usrnm);

            DataHelper.conn.Open();
            string result = (string) exist_cmd.ExecuteScalar();
            DataHelper.conn.Close();

            return result != null;
        }

        public static bool ExistEmail(string email)
        {
            var exist_cmd = new SqlCommand(
                $"SELECT [Email] FROM {DataHelper.UserT} " +
                $"WHERE [Email] = @email", DataHelper.conn);
            exist_cmd.Parameters.AddWithValue("@email", email);

            DataHelper.conn.Open();
            string result = (string)exist_cmd.ExecuteScalar();
            DataHelper.conn.Close();

            return result != null;
        }

        public string UserID   { get; private set; }
        public string Username { get; private set; }
        public string Password { private get; set; }
        public string FullName { get; set; }
        public string Email    { get; private set; }
        public string Role     { get; private set; }

        public ItemUser(string userID, string username, string password, string fullName, string email, string role)
        {
            UserID   = userID;
            Username = username;
            Password = password;
            FullName = fullName;
            Email    = email;
            Role     = role;
        }

        public string SaveEdit(string username, string fullName, string email, string newPassword)
        {
            if (new[] { username, fullName, email }.Any(string.IsNullOrEmpty))
                return "Invallid Values";

            var update_cmd = new SqlCommand(
                $"UPDATE {DataHelper.UserT} SET " +
                "[Username] = @usrnm" +
                (fullName != FullName ?
                ", [FullName] = @fulnm" : "") +
                (email != Email ?
                ", [Email] = @email" : "") +
                (newPassword != string.Empty && newPassword != Password ?
                ", [Password] = @paswd" : "") +
                " WHERE [UserID] = @usrid", DataHelper.conn);
            update_cmd.Parameters.AddWithValue("@usrnm", username);
            update_cmd.Parameters.AddWithValue("@fulnm", fullName);
            update_cmd.Parameters.AddWithValue("@email", email);
            update_cmd.Parameters.AddWithValue("@paswd", newPassword);
            update_cmd.Parameters.AddWithValue("@usrid", UserID);

            DataHelper.conn.Open();
            int count = update_cmd.ExecuteNonQuery();
            DataHelper.conn.Close();

            if (count < 1)
                return "Failed to update database.";

            Username = username;
            FullName = fullName;
            Email    = email;
            Password = (newPassword != string.Empty) ? newPassword : Password;
            return null;
        }
    }
}
