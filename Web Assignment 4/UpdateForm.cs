using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Web_Assignment_4
{
    public partial class UpdateForm : Form
    {
        private readonly string connectionString = "Server=127.0.0.1;Database=books;Uid=root;Pwd=;";

        public UpdateForm()
        {
            InitializeComponent();
        }
   private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string bookName = txtBookName.Text;
                    string bookGenre = txtBookGenre.Text;
                    string query = "UPDATE Books SET BookGenre = @BookGenre WHERE BookName = @BookName";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookName", bookName);
                        command.Parameters.AddWithValue("@BookGenre", bookGenre);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book updated successfully!");
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
