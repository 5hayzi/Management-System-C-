using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Web_Assignment_4
{
    public partial class SearchForm : Form
    {
        private readonly string connectionString = "Server=127.0.0.1;Database=books;Uid=root;Pwd=;";
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string bookName = txtBookName.Text;
                    string query = "SELECT * FROM Books WHERE BookName = @BookName";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookName", bookName);
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string bookId = reader["BookId"].ToString();
                                string bookGenre = reader["BookGenre"].ToString();

                                MessageBox.Show($"Book ID: {bookId}\nBook Genre: {bookGenre}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Book not found!");
                        }
                        reader.Close();
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
