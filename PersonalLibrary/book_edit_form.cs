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
    public partial class book_edit_form : Form
    {
        SqlConnection conn2 = new SqlConnection();
        public book_edit_form()
        {
            InitializeComponent();
        }

        private void updateTextBoxes()
        {
            if (dataGridView_book.CurrentRow == null)
            {
                MessageBox.Show("first insert something");
                Close();
            }
            else
            {

                txtbox_edit_ban.Text = (string)dataGridView_book.CurrentRow.Cells[1].Value;
                txtbox_edit_btn.Text = (string)dataGridView_book.CurrentRow.Cells[2].Value;
                txtbox_edit_bd.Text = (string)dataGridView_book.CurrentRow.Cells[3].Value;
                txtbox_edit_byp.Text = (string)dataGridView_book.CurrentRow.Cells[4].Value;
            }

        }

        private void book_edit_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DatabaseDataSet7.TBLbook' table. You can move, or remove it, as needed.
            this.tBLbookTableAdapter.Fill(this.library_DatabaseDataSet7.TBLbook);
            updateTextBoxes();
            conn2 = tBLbookTableAdapter.Connection;
            conn2.Open();
        }

        private void btn_edit_book_Click(object sender, EventArgs e)
        {
            if (dataGridView_book.CurrentRow == null)
            {
                MessageBox.Show("Not selected anything!");
                Close();
            }
            SqlCommand query = new SqlCommand(@"UPDATE TBLBook SET book_author = @BookAuthor, book_title = @BookTitle, book_description = @BookDescription, year_of_publish = @YearOfPublish WHERE id = @BookID", conn2);
            query.Parameters.AddWithValue("BookAuthor", txtbox_edit_ban.Text);
            query.Parameters.AddWithValue("BookTitle", txtbox_edit_btn.Text);
            query.Parameters.AddWithValue("BookDescription", txtbox_edit_bd.Text);
            query.Parameters.AddWithValue("YearOfPublish", txtbox_edit_byp.Text);
            query.Parameters.AddWithValue("BookID", (int)dataGridView_book.CurrentRow.Cells[0].Value);

            query.ExecuteNonQuery();
            MessageBox.Show("Edited Successfuly!");
            this.tBLbookTableAdapter.Fill(this.library_DatabaseDataSet7.TBLbook);
        }

        private void dataGridView_OnSelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_book.CurrentRow == null)
            {
                return;
            }
            updateTextBoxes();
        }
    }
}
