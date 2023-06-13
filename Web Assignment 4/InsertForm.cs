using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Web_Assignment_4
{
    public partial class InsertForm : Form
    {
        private readonly string connectionString = "Server=127.0.0.1;Database=books;Uid=root;Pwd=;";

        public InsertForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve values from text fields
                    string bookName = txtBookName.Text;
                    int bookId = int.Parse(txtBookId.Text);
                    string bookGenre = txtBookGenre.Text;

                    // Create the SQL query
                    string query = "INSERT INTO Books (BookName, BookId, BookGenre) VALUES (@BookName, @BookId, @BookGenre)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@BookName", bookName);
                        command.Parameters.AddWithValue("@BookId", bookId);
                        command.Parameters.AddWithValue("@BookGenre", bookGenre);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
