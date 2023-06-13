using System;
using System.Windows.Forms;

namespace Web_Assignment_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Open the Insert Form
            var insertForm = new InsertForm();
            insertForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Open the Delete Form
            var deleteForm = new DeleteForm();
            deleteForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Open the Search Form
            var searchForm = new SearchForm();
            searchForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Open the Update Form
            var updateForm = new UpdateForm();
            updateForm.Show();
        }
    }
}
