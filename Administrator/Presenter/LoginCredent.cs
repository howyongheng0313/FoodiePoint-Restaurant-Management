using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Customers
{
    class LoginCredent
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ConnectionString;

        private int _userId;
        private string _username;
        private string _password; // Plain text password
        private string _userType;
        private string _email;

        // Public properties with private backing fields
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string UserType
        {
            get { return _userType; }
            protected set { _userType = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Virtual method for login validation
        //public virtual bool Login(string username, string password)
        //{
        //    return DatabaseHelper.ValidateUser(username, password);
        //}

        public string GetUserType(string username)
        {
            string result = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Role FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();
                result = (string)cmd.ExecuteScalar();
            }
            MessageBox.Show(result);
            return result;
            
        }

        public string RetrievePassword(string password,string username)
        {
            string result = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Password FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();
                result = (string)cmd.ExecuteScalar();
            }
            if (result==password)
            {
                MessageBox.Show("Correct");
            }

            return result;

        }


        //    private void OpenDashboard(string result)
        //    {
        //        Form dashboard;

        //        switch (result.UserType)
        //        {
        //            case "Admin":
        //                dashboard = new FrmAdmin();
        //                break;
        //            //case "Chef":
        //            //    dashboard = new ChefDashboard();
        //            //    break;
        //            //case "Manager":
        //            //    dashboard = new ManagerDashboard();
        //            //    break;
        //            //case "ReservationCoordinator":
        //            //    dashboard = new ReservationDashboard();
        //            //    break;
        //            //case "Customer":
        //            //    dashboard = new CustomerDashboard();
        //            //    break;
        //            default:
        //                throw new NotImplementedException("User type not supported.");
        //        }

        //        //this.Hide();
        //        dashboard.Show();
        //    }

        //    public void login(string username, string password)
        //    {
        //        try
        //        {
        //            //string username = txtUser.Text.Trim();
        //            //string password = txtPassword.Text;

        //            if (DatabaseHelper.ValidateUser(username, password))
        //            {
        //                // Get user type from database
        //                string userType = GetUserType(username);

        //                User currentUser = UserFactory.CreateUser(userType);
        //                OpenDashboard(currentUser);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Invalid credentials");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error: {ex.Message}");
        //        }
        //    }


        //    // User Factory
        //    public static class UserFactory
        //    {
        //        public static User CreateUser(string userType)
        //        {
        //            if (userType == "Admin") return new Adminstrator();
        //            else if (userType == "Chef") return new Chef();
        //            else if (userType == "Manager") return new Manager();
        //            else if (userType == "ReservationCoordinator") return new ReservationCoordinator();
        //            else if (userType == "Customer") return new Customer();
        //            else throw new ArgumentException("Invalid user type");
        //        }
        //    }

        //    // Database Helper
        //    public static class DatabaseHelper
        //    {
        //        private static string connectionString = ConfigurationManager.ConnectionStrings["FoodiePointDB"].ConnectionString;

        //        public static bool ValidateUser(string username, string password)
        //        {
        //            using (SqlConnection conn = new SqlConnection(connectionString))
        //            {
        //                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
        //                SqlCommand cmd = new SqlCommand(query, conn);
        //                cmd.Parameters.AddWithValue("@Username", username);
        //                cmd.Parameters.AddWithValue("@Password", password); // Directly compare plain text password

        //                conn.Open();
        //                int result = (int)cmd.ExecuteScalar();
        //                return result > 0;
        //            }
        //        }
        //    }
        //}
    }
}

