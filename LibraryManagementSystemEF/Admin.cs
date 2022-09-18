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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        DB_LibraryEntities db = new DB_LibraryEntities();
        public Form adminReturned = new Form();
        public Form finedUsers = new Form();
        private void Admin_Load(object sender, EventArgs e)
        {
            lbl_name.Text = (from u in db.TBL_User
                             where u.UserID == Globals.userID
                             select u).Max(u => u.Name + " " + u.LastName);
            lbl_numBooks.Text += db.TBL_Book.Count().ToString();
            lbl_numBorrowed.Text += db.TBL_Borrowed.Where(b=>b.Status==1).Count().ToString();
            lbl_numCat.Text += db.TBL_Category.Count().ToString();
            lbl_numUsers.Text += db.TBL_User.Count().ToString();
            lbl_numReturned.Text += db.TBL_Borrowed.Where(b => b.Status == 0).Count().ToString();
            lbl_numFined.Text += db.TBL_Borrowed.Where(b => b.Status == 1 && b.Return_date.CompareTo(DateTime.Now) < 0).Count().ToString();
        }

        private void lbl_numReturned_Click(object sender, EventArgs e)
        {
            
            adminReturned.Show();
            adminReturned.Size = new Size(800, 400);
            adminReturned.BackColor = Color.FromArgb(252, 191, 73);

            DataGridView dgw_returned = new DataGridView();
            dgw_returned.DataSource = db.TBL_Borrowed.Join(db.TBL_Book,
                                                            brwd => brwd.BookID,
                                                            book => book.Book_ID,
                                                            (brwd, book) => new { Borrowed = brwd, Book = book }).Join(db.TBL_User,
                                                            bUser => bUser.Borrowed.UserID,
                                                            user => user.UserID,
                                                            (bUser, user) => new { BorrowedUser = bUser, User = user }).Select(b => new
                                                            {
                                                                b.BorrowedUser.Borrowed.BorrowID,
                                                                b.BorrowedUser.Book.Title,
                                                                b.User.Name,
                                                                b.BorrowedUser.Borrowed.Issued_date,
                                                                b.BorrowedUser.Borrowed.Return_date,
                                                                b.BorrowedUser.Borrowed.Status
                                                            }).Where(b => b.Status == 0).ToList();
                                        
            dgw_returned.Size = new Size(600, 250);
            dgw_returned.Location = new Point(100, 25);
           

            Button btn_back = new Button();
            btn_back.ForeColor = Color.FromArgb(2, 48, 71);
            btn_back.BackColor = Color.FromArgb(142, 202, 230);
            btn_back.Size = new Size(107, 51);
            btn_back.Location = new Point(100, 290);
            btn_back.Text = "Back";
            btn_back.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);

            btn_back.Click += new System.EventHandler(this.btn_back_Click);

            adminReturned.Controls.Add(dgw_returned);
          
            adminReturned.Controls.Add(btn_back);
            this.Hide();
            
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            adminReturned.Dispose();
           
            this.Show();
        }
        private void btn_back1_Click(object sender, EventArgs e)
        {
            finedUsers.Dispose();

            this.Show();
        }
        private void lbl_numBooks_Click(object sender, EventArgs e)
        {
            
            AdminBook b = new AdminBook();
            b.ShowDialog();
        }

        private void lbl_numBorrowed_Click(object sender, EventArgs e)
        {
            AdminBorrowed b = new AdminBorrowed();
            b.ShowDialog();
            
        }

        private void lbl_numCat_Click(object sender, EventArgs e)
        {
            AdminCategories c = new AdminCategories();
            c.Show();
            this.Hide();
        }

        private void lbl_numUsers_Click(object sender, EventArgs e)
        {
            AdminUser user = new AdminUser();
            user.Show();
        }

        private void lbl_numFined_Click(object sender, EventArgs e)
        {
            finedUsers.Show();
            finedUsers.Size = new Size(800, 400);
            finedUsers.BackColor = Color.FromArgb(252, 191, 73);
            adminReturned.Size = new Size(800, 400);
            adminReturned.BackColor = Color.FromArgb(252, 191, 73);
            DataGridView dgw_fined = new DataGridView();
            dgw_fined.DataSource = db.TBL_Borrowed.Join(db.TBL_Book,
                                                            brwd => brwd.BookID,
                                                            book => book.Book_ID,
                                                            (brwd, book) => new { Borrowed = brwd, Book = book }).Join(db.TBL_User,
                                                            bUser => bUser.Borrowed.UserID,
                                                            user => user.UserID,
                                                            (bUser, user) => new { BorrowedUser = bUser, User = user }).Select(b => new
                                                            {
                                                                b.BorrowedUser.Borrowed.BorrowID,
                                                                b.BorrowedUser.Book.Title,
                                                                b.User.Name,
                                                                b.BorrowedUser.Borrowed.Issued_date,
                                                                b.BorrowedUser.Borrowed.Return_date,
                                                                b.BorrowedUser.Borrowed.Status
                                                            }).Where(b => b.Status == 1 && b.Return_date.CompareTo(DateTime.Now)<0).ToList();

            dgw_fined.Size = new Size(600, 250);
            dgw_fined.Location = new Point(100, 25);


            Button btn_back1 = new Button();
            btn_back1.ForeColor = Color.FromArgb(2, 48, 71);
            btn_back1.BackColor = Color.FromArgb(142, 202, 230);
            btn_back1.Size = new Size(107, 51);
            btn_back1.Location = new Point(100, 290);
            btn_back1.Text = "Back";
            btn_back1.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);

            btn_back1.Click += new System.EventHandler(this.btn_back1_Click);

            finedUsers.Controls.Add(dgw_fined);
            finedUsers.Controls.Add(btn_back1);
            
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
