using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class addhistory : Form
    {


        public addhistory()
        {
            InitializeComponent();

            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;


            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txb_id.Text.ToString();
            string makh = txb_makh.Text.ToString();
            int masp = int.Parse(txb_masp.Text.ToString());
            int date = int.Parse(txb_date.Text.ToString());
            int soluong = int.Parse(txbsoluong.Text.ToString());
            int trangthai = int.Parse(txbtrangthai.Text.ToString());

            InsertData(id, makh, masp, date, soluong, trangthai); 



        }

        private void InsertData(string id, string makh, int masp, int date, int soluong, object trangthai)
        {
            throw new NotImplementedException();
        }

        private void InsertData(string id, string makh, int masp, int date, int soluong, object trangthai)
        {
            // Connection string to your database

            // SQL query to insert data
            string query = "INSERT INTO history  (id, makh , masp, date ,soluong,trangthai ) VALUES (@id  , @makh, @masp, @date , @soluong , @trangthai )";


            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create the SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@id ", id);

                        command.Parameters.AddWithValue("@makh", makh);
                        command.Parameters.AddWithValue("@masp", masp);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@soluong",soluong);
                        command.Parameters.AddWithValue("@trangthai", trangthai);
                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void addhistory_Load(object sender, EventArgs e)
        {

        }
    }
}
