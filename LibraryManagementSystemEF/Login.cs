using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LibraryManagementSystemEF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DB_LibraryEntities db = new DB_LibraryEntities();
        private void btn_login_Click(object sender, EventArgs e)
        {
            byte[] getHash = System.Text.Encoding.UTF8.GetBytes(tb_psw.Text);
            string psw = Globals.GetHashCodePsw(getHash);
            var query = from user in db.TBL_User
                        where user.Email == tb_email.Text && user.Password == psw
                        select user;
          

            if(string.IsNullOrEmpty(tb_email.Text) || string.IsNullOrEmpty(tb_psw.Text))
            {
                lbl_warning.Text = "Fill out all the fields!";
                lbl_warning.Visible = true;
               
            }
            else
            {
                if (query.SingleOrDefault() != null)
                {

                    Globals.userEmail = tb_email.Text;
                    Globals.userID = query.Max(p => p.UserID);
                    var user = db.TBL_User.Find(Globals.userID);
                    if (user.Status != 1)
                    {
                        Dashboard d = new Dashboard();
                        d.Show();

                    }
                    else
                    {
                        Admin a = new Admin();
                        a.Show();

                    }
                }
                else
                {
                    lbl_warning.Text = "Email or password is incorrect.";
                    lbl_warning.Visible = true;
                }
            }
           
        }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            tb_psw.PasswordChar = cb_show.Checked ? '\0' : '•';
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lbl_inf_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            
        }

        private void lbl_forget_Click(object sender, EventArgs e)
        {

        }
    }
}
