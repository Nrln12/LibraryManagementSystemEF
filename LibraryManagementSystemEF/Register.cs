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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            db = new DB_LibraryEntities();
        }
        readonly DB_LibraryEntities db;
        private void btn_register_Click(object sender, EventArgs e)
        {
            TBL_User user = new TBL_User();
            if(string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_lName.Text) || string.IsNullOrEmpty(tb_email.Text) || string.IsNullOrEmpty(tb_psw.Text) || string.IsNullOrEmpty(tb_conf.Text))
            {
                lbl_warning.Text = "Please fill out empty fields.";
                lbl_warning.Visible = true;
            }
            else
            {
                List<string> emails = new List<string>();
                emails.AddRange(from u in db.TBL_User
                                select u.Email);                
                if (emails.Contains(tb_email.Text))
                {
                    lbl_warning.Text = "This email has already registered.";
                    lbl_warning.Visible = true;
                }
                else
                {
                    if (tb_psw.Text.Length < 6)
                    {
                        lbl_warning.Text = "Password length has to be more than 6";
                        lbl_warning.Visible = true;
                    }
                    else
                    {
                        
                            bool isDigit = tb_psw.Text.Any(c => char.IsDigit(c));
                            bool isUpper = tb_psw.Text.Any(c => char.IsUpper(c));
                            if (isDigit && isUpper)
                               
                            {
                            if (tb_psw.Text == tb_conf.Text)
                            {
                                user.Name = tb_name.Text;
                                user.LastName = tb_lName.Text;
                                user.Email = tb_email.Text;
                                byte[] getHash = System.Text.Encoding.UTF8.GetBytes(tb_psw.Text);
                                user.Password = Globals.GetHashCodePsw(getHash).ToString();
                                db.TBL_User.Add(user);
                                lbl_warning.Text = "You've registered successfully";
                                lbl_warning.ForeColor = System.Drawing.Color.FromArgb(46, 196, 182);
                                lbl_warning.Visible = true;
                                db.SaveChanges();
                                Login login = new Login();
                                login.Show();
                                this.Hide();
                            }
                            else
                            {
                                lbl_warning.Text = "Passwords don't match";
                                lbl_warning.Visible = true;
                            }
                        }
                            else
                            {
                            lbl_warning.Text = "Password has to contain at least 1 upper letter and number";
                            lbl_warning.Visible = true;
                            }
                        }
                    }
                }


            }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            tb_psw.PasswordChar = cb_show.Checked ? '\0' : '•';
            tb_conf.PasswordChar = cb_show.Checked ? '\0' : '•';
        }

        private void lbl_inf_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
    }

