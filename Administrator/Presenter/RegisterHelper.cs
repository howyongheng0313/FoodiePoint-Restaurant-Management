using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace Admin.Presenter
{
    public static class RegisterHelper
    {
        public static bool RegisterNewUser(string username, string password, string fullName, string email, string role)
        {
            var register_cmd = new SqlCommand(
                $"INSERT INTO {LoginCredent.tb_code} " +
                "(Username, Password, FullName, Email, Role) " +
                "VALUES (@usrnm, @paswd, @fulnm, @email, @role)", DataHelper.conn);

            register_cmd.Parameters.AddWithValue("@usrnm", username);
            register_cmd.Parameters.AddWithValue("@paswd", password);
            register_cmd.Parameters.AddWithValue("@fulnm", fullName);
            register_cmd.Parameters.AddWithValue("@email", email);
            register_cmd.Parameters.AddWithValue("@role", role);

            DataHelper.conn.Open();
            int result = register_cmd.ExecuteNonQuery();
            DataHelper.conn.Close();

            return result > 0;
        }
    }
}
