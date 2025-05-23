﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    internal class Database
    {
        private string connectionString;
        public Database()
        {
            connectionString = global::FoodiePoint_proj.Properties.Settings.Default.FoodieDbConnectionString;
        }
        public void LoadData(DataGridView dataGridView, string x)
        {

            string query = $"SELECT * FROM {x}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No data retrieved from the database.");
                }
                dataGridView.DataSource = table;
                dataGridView.Refresh();
            }
        }

        public void AddItem(string name, double price, string category)
        {
            try
            {
                string query = $"INSERT INTO Menu (ItemName, ItemPrice, ItemCategory) VALUES ('{name}', {price}, '{category}')";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateItem(string id, string name, double price, string category)
        {
            try
            {
                string query = $"UPDATE Menu SET ItemName = '{name}', ItemPrice = {price}, ItemCategory = '{category}' WHERE ItemID = '{id}'";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteItem(string id)
        {
            string query = "DELETE FROM Menu WHERE ItemID = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void AddReservation(string hallID, string userID, string reservationDate, string reservationType, string reservationStatus)
        {
            try
            {
                string query = $"INSERT INTO Reservations (HallID,UserID,ReservationDate,ReservationType,ReservationStatus) VALUES ('{hallID}', '{userID}', '{reservationDate}','{reservationType}','{reservationStatus}')";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddHall(string hallName, string hallPartyType, int hallCapacity, string availability)
        {
            try
            // Validate input parameters
            {
                string query = $"INSERT INTO Halls (HallName,HallPartyType,HallCapacity,Availability) VALUES ('{hallName}', '{hallPartyType}', '{hallCapacity}','{availability}')";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateHall(string HallID, string HallName, string HallPartyType, int HallCapacity, string Availability)
        {
            try
            {
                string query = $"UPDATE Halls SET HallName = '{HallName}', HallPartyType = '{HallPartyType}', HallCapacity = '{HallCapacity}', Availability = '{Availability}'  WHERE HallID = '{HallID}'";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteHall(string hallid)
        {
            string query = "DELETE FROM Halls WHERE HallID = @hallid";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@hallid", hallid);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AddReservation(string RsID, string HallID, string UserID, DateTime RsDate, string RsType, string RsStatus)
        {
            try
            {
                string query = $"INSERT INTO Reservations (ReservationID,HallID,UserID,ReservationDate,ReservationType,ReservationStatus) VALUES ('{RsID}', '{HallID}', '{UserID}', '{RsDate}','{RsType}','{RsStatus}')";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateReservation(string RsID, string HallID, string UserID, DateTime RsDate, string RsType, string RsStatus)
        {
            try
            {
                string query = $"UPDATE Reservations SET ReservationID = '{RsID}', HallID = '{HallID}', UserID = '{UserID}', ReservationDate = '{RsDate}', ReservationType = '{RsType}', ReservationStatus = '{RsStatus}'  WHERE HallID = '{HallID}'";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteReservation(string rsid)
        {
            string query = "DELETE FROM Reservations WHERE ReservationID = @rsid";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@rsid", rsid);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateProfile(string UserID, string Username, string Password, string FullName, string Email, string Role)
        {
            try
            {
                string query = $"UPDATE Users SET UserID = '{UserID}', Username = '{Username}', Password = '{Password}', FullName = '{FullName}', Email = '{Email}', Role = '{Role}'  WHERE UserID = '{UserID}'";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FilterMonth(DataGridView dataGridView, string x, int month)
        {

            string query = $"SELECT * FROM {x} WHERE MONTH(ReservationDate) = @month";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@month", month);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No data retrieved from the database.");
                }
                dataGridView.DataSource = table;
                dataGridView.Refresh();
            }
        }
        public void SearchReservationType(DataGridView dataGridView, string x, string search)
        {

            string query = $"SELECT * FROM {x} WHERE ReservationType LIKE @search";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No data retrieved from the database.");
                }
                dataGridView.DataSource = table;
                dataGridView.Refresh();
            }
        }

        public void SearchReservationID(DataGridView dataGridView, string x, string search)
        {

            string query = $"SELECT * FROM {x} WHERE ReservationID LIKE @search";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No data retrieved from the database.");
                }
                dataGridView.DataSource = table;
                dataGridView.Refresh();
            }
        }

        public void SearchHallID(DataGridView dataGridView, string x, string search)
        {

            string query = $"SELECT * FROM {x} WHERE HallID LIKE @search";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No data retrieved from the database.");
                }
                dataGridView.DataSource = table;
                dataGridView.Refresh();
            }
        }
        public void SearchUserID(DataGridView dataGridView, string x, string search)
        {

            string query = $"SELECT * FROM {x} WHERE UserID LIKE @search";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No data retrieved from the database.");
                }
                dataGridView.DataSource = table;
                dataGridView.Refresh();
            }
        }

        public void SearchReservationStatus(DataGridView dataGridView, string x, string search)
        {
            string query = $"SELECT * FROM {x} WHERE ReservationStatus LIKE @search";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No data retrieved from the database.");
                }
                dataGridView.DataSource = table;
                dataGridView.Refresh();
            }
        }
    }
}
