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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        DB_LibraryEntities db = new DB_LibraryEntities();
        private void lbl_inf_Click(object sender, EventArgs e)
        {
            List<TBL_User> user = db.TBL_User.Where(u=>u.UserID==Globals.userID).ToList();
            dgw_dashboard.DataSource = user;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var name = from u in db.TBL_User
                       where u.UserID == Globals.userID
                       select u;
            lbl_name.Text = name.Max(u => u.Name + " " + u.LastName);
          
        }

        private void lbl_update_Click(object sender, EventArgs e)
        {
                dgw_dashboard.DataSource = db.TBL_User.Where(u => u.UserID == Globals.userID).ToList();
                lbl_newpsw.Visible = true;
                tb_newpsw.Visible = true;
                btn_change.Visible = true;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            bool isDigit = tb_newpsw.Text.Any(c => char.IsDigit(c));
            bool isUpper = tb_newpsw.Text.Any(c => char.IsUpper(c));
            if (isDigit && isUpper)
            {
                var user = db.TBL_User.Find(Globals.userID);
                byte[] getHash = System.Text.Encoding.UTF8.GetBytes(tb_newpsw.Text);
                user.Password = Globals.GetHashCodePsw(getHash).ToString();
                db.SaveChanges();
                dgw_dashboard.Refresh();
            }
            else
            {
                MessageBox.Show("Password must contain at least one number and upper letter.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            var listBook = from b in db.TBL_Book
                           where b.Author.Contains(tb_search.Text) ||
                           b.Title.Contains(tb_search.Text) && b.Stock>=1
                           select b;
            
            dgw_dashboard.DataSource = listBook.ToList();
            
        }

        private void lbl_borrow_Click(object sender, EventArgs e)
        {
            int count = dgw_dashboard.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            if (count > 0)
            {
                int countBook = db.TBL_Borrowed.Where(b => b.UserID == Globals.userID && b.Status == 1).Count();
                if (countBook < 4)
                {
                    DataGridViewRow data = this.dgw_dashboard.SelectedRows[0];
                    var id = data.Cells["Book_ID"].Value;
                    GetBookUser getBookUser = new GetBookUser();
                    getBookUser.ID = Convert.ToInt32(id);
                    getBookUser.Show();
                }
                else
                {
                    MessageBox.Show("You can't borrow more than 3 books.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select any book", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
