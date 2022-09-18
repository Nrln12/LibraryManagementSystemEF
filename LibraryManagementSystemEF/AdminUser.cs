using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LibraryManagementSystemEF
{
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
            db = new DB_LibraryEntities();
        }
        readonly DB_LibraryEntities db;
        private void AdminUser_Load(object sender, EventArgs e)
        {
            dgw_user.DataSource = db.TBL_User.Where(u => u.Status == 0).ToList();
            dgw_user.Columns[5].Visible = false;
            dgw_user.Columns[6].Visible = false;

        }
       
        private void dgw_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_UserID.Text = dgw_user.SelectedCells[0].Value.ToString();
            tb_name.Text = dgw_user.SelectedCells[1].Value.ToString();
            tb_last.Text = dgw_user.SelectedCells[2].Value.ToString();
            tb_email.Text = dgw_user.SelectedCells[3].Value.ToString();
            tb_psw.Text = dgw_user.SelectedCells[4].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(dgw_user.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to change user information?", "Confirm",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    var user = db.TBL_User.Find((int)dgw_user.SelectedCells[0].Value);
                    user.Name = tb_name.Text;
                    user.LastName = tb_last.Text;
                    user.Email = tb_email.Text;
                    byte[] getHash = System.Text.Encoding.UTF8.GetBytes(tb_psw.Text);
                    string newPsw = Globals.GetHashCodePsw(getHash);
                    user.Password = newPsw;
                    db.SaveChanges();
                    dgw_user.Refresh();
                } 
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to change values?", "Confirm",
                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                TBL_User user = new TBL_User();
                user.Name = tb_name.Text;
                user.LastName = tb_last.Text;
                user.Email = tb_email.Text;
                byte[] getHash = System.Text.Encoding.UTF8.GetBytes(tb_psw.Text);
                user.Password = Globals.GetHashCodePsw(getHash).ToString();
                db.TBL_User.Add(user);
                db.SaveChanges();
                dgw_user.Refresh();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            if(dgw_user.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete user information?", "Confirm",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    var user = db.TBL_User.Find((int)dgw_user.SelectedCells[0].Value);
                    user.Status = 2;
                    db.SaveChanges();
                    dgw_user.Refresh();
                } 
            }
        }
    }
}
