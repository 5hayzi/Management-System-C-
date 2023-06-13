using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Web_Assignment_4
{
    public partial class DeleteForm : Form
    {
        private readonly string connectionString = "Server=127.0.0.1;Database=books;Uid=root;Pwd=;";
        public DeleteForm()
        {
            InitializeComponent();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string bookName = txtBookName.Text;
                    string query = "DELETE FROM Books WHERE BookName = @BookName";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookName", bookName);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Book not found!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
