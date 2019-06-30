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

namespace PersonalLibrary
{
    public partial class book_add_form : Form
    {
        SqlConnection conn1 = new SqlConnection();
        public book_add_form()
        {
            InitializeComponent();
        }

        private void radiobtn_is_read_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_book_Click(object sender, EventArgs e)
        {
            string commandString = @"INSERT INTO TBLbook(book_author,book_genre,book_title,book_description,year_of_publish,book_status,book_shabak) VALUES(@author,@genre,@title, @desc, @year,'FALSE',@shabak)";


            SqlCommand command = new SqlCommand(commandString, conn1);
            command.Parameters.AddWithValue("author", txt_book_author.Text);
            command.Parameters.AddWithValue("genre", combox_book.Text);
            command.Parameters.AddWithValue("title", txt_book_name.Text);
            command.Parameters.AddWithValue("desc", txt_book_description.Text);
            command.Parameters.AddWithValue("year", txt_book_publish_year.Text);
            command.Parameters.AddWithValue("shabak", "1234567890");

            command.ExecuteNonQuery();
            MessageBox.Show("added successfully!");
        }

        private void book_add_form_Load(object sender, EventArgs e)
        {
            conn1.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Library_Database.mdf;Integrated Security=True";
            conn1.Open();
        }
    }
}
