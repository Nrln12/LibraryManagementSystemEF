using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemEF
{
    public partial class GetBookUser : Form
    {
        public int ID;
        DB_LibraryEntities db = new DB_LibraryEntities();
        public GetBookUser()
        {
            InitializeComponent();
           
        }

        private void GetBookUser_Load(object sender, EventArgs e)
        {
            var book = db.TBL_Book.Find(ID);
            tb_bookTitle.Text = book.Title;
            tb_author.Text = book.Author;
            tb_page.Text = book.Page_Count.ToString();
            tb_category.Text = book.Category.ToString();
            dtp_return.Value = dtp_borrow.Value.AddDays(7);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            var findBook = db.TBL_Book.Find(ID);
            if (findBook.Stock >= 1)
            {
                TBL_Borrowed borrowBook = new TBL_Borrowed();
                var book = from b in db.TBL_Book
                           where b.Title == tb_bookTitle.Text
                           select b;

                findBook.Stock -= 1;
                borrowBook.BookID = book.Max(b => b.Book_ID);
                borrowBook.Issued_date = dtp_borrow.Value;
                borrowBook.UserID = Globals.userID;
                borrowBook.Return_date = dtp_return.Value;
                db.TBL_Borrowed.Add(borrowBook);

                db.SaveChanges();
                dataGridView1.DataSource = db.TBL_Borrowed.ToList();
            }
            else
            {
                MessageBox.Show("Book has ended up", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }
    }
}
