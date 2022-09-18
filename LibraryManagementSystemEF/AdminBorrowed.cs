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
    public partial class AdminBorrowed : Form
    {
        public AdminBorrowed()
        {
            db = new DB_LibraryEntities();
            InitializeComponent();
        }
        readonly DB_LibraryEntities db;
        public void DGW_BLoad()
        {
            
                var borrowed = from b in db.TBL_Borrowed
                               join u in db.TBL_User
                               on b.UserID equals u.UserID
                               join k in db.TBL_Book
                               on b.BookID equals k.Book_ID
                               orderby b.BorrowID
                               select new
                               {
                                   b.BorrowID,
                                   FullName = u.Name + " " + u.LastName,
                                   k.Title,
                                   b.Issued_date,
                                   b.Return_date,
                                   b.Status

                               };
                dgw_brwd.DataSource = borrowed.Where(b => b.Status == 1).ToList();

                cb_book.DataSource = db.TBL_Book.Where(b => b.Stock != 0).ToList();
                cb_book.DisplayMember = "Title";
                cb_book.ValueMember = "Book_ID";

                cb_user.DataSource = db.TBL_User.Where(u => u.Status == 0).ToList();
                cb_user.DisplayMember = "Name";
                cb_user.DisplayMember += "LastName";
                cb_user.ValueMember = "UserID";
          
        }
        private void AdminBorrowed_Load(object sender, EventArgs e)
        {
            DGW_BLoad();
        }

        private void dgw_brwd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_book.Text = dgw_brwd.SelectedCells[2].Value.ToString();
            cb_user.Text = dgw_brwd.SelectedCells[1].Value.ToString();
            dtp_borrow.Value = (DateTime)dgw_brwd.SelectedCells[3].Value;
            dtp_return.Value = (DateTime)dgw_brwd.SelectedCells[4].Value;
            tbStatus.Text = dgw_brwd.SelectedCells[5].Value.ToString();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgw_brwd.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to update values?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgw_brwd.SelectedCells[0].Value);
                    var bookBrw = db.TBL_Borrowed.Find(id);
                    bookBrw.Status = 0;
                    db.TBL_Book.Find(bookBrw.BookID).Stock += 1;
                    db.SaveChanges();
                    DGW_BLoad();

                }
            }
            else
            {
                MessageBox.Show("Please select any rows to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to add values?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                TBL_Borrowed borrowed = new TBL_Borrowed();
                borrowed.BookID = (int)cb_book.SelectedValue;
                borrowed.UserID = (int)cb_user.SelectedValue;
                borrowed.Issued_date = (DateTime)dtp_borrow.Value;
                dtp_return.Value = dtp_borrow.Value.AddDays(7);
                borrowed.Return_date = (DateTime)dtp_return.Value;
                borrowed.Status = 1;
                db.TBL_Borrowed.Add(borrowed);
                db.TBL_Book.Find(borrowed.BookID).Stock -= 1;
                db.SaveChanges();
                DGW_BLoad();
            }
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            var book = db.TBL_Borrowed.Find(dgw_brwd.SelectedCells[0].Value);
            book.Return_date = dtp_return.Value;
            db.SaveChanges();
            DGW_BLoad();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
