
namespace LibraryManagementSystemEF
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_psw = new System.Windows.Forms.Label();
            this.cb_show = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_inf = new System.Windows.Forms.Label();
            this.lbl_title2 = new System.Windows.Forms.Label();
            this.lbl_title1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_psw = new System.Windows.Forms.TextBox();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.lbl_forget = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.tb_email.Location = new System.Drawing.Point(488, 67);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(300, 27);
            this.tb_email.TabIndex = 0;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_email.Location = new System.Drawing.Point(384, 65);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(77, 32);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email";
            // 
            // lbl_psw
            // 
            this.lbl_psw.AutoSize = true;
            this.lbl_psw.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_psw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_psw.Location = new System.Drawing.Point(338, 128);
            this.lbl_psw.Name = "lbl_psw";
            this.lbl_psw.Size = new System.Drawing.Size(123, 32);
            this.lbl_psw.TabIndex = 4;
            this.lbl_psw.Text = "Password";
            // 
            // cb_show
            // 
            this.cb_show.AutoSize = true;
            this.cb_show.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.cb_show.Location = new System.Drawing.Point(488, 192);
            this.cb_show.Name = "cb_show";
            this.cb_show.Size = new System.Drawing.Size(128, 21);
            this.cb_show.TabIndex = 5;
            this.cb_show.Text = "Show password";
            this.cb_show.UseVisualStyleBackColor = true;
            this.cb_show.CheckedChanged += new System.EventHandler(this.cb_show_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(73)))), ((int)(((byte)(52)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.btn_login.Location = new System.Drawing.Point(488, 237);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(300, 51);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.lbl_title.Location = new System.Drawing.Point(3, 65);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(153, 51);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Library ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.lbl_inf);
            this.panel1.Controls.Add(this.lbl_title2);
            this.panel1.Controls.Add(this.lbl_title1);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 450);
            this.panel1.TabIndex = 7;
            // 
            // lbl_inf
            // 
            this.lbl_inf.AutoSize = true;
            this.lbl_inf.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inf.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_inf.Location = new System.Drawing.Point(170, 422);
            this.lbl_inf.Name = "lbl_inf";
            this.lbl_inf.Size = new System.Drawing.Size(137, 19);
            this.lbl_inf.TabIndex = 4;
            this.lbl_inf.Text = "Haven\'t account yet?";
            this.lbl_inf.Click += new System.EventHandler(this.lbl_inf_Click);
            // 
            // lbl_title2
            // 
            this.lbl_title2.AutoSize = true;
            this.lbl_title2.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.lbl_title2.Location = new System.Drawing.Point(164, 192);
            this.lbl_title2.Name = "lbl_title2";
            this.lbl_title2.Size = new System.Drawing.Size(143, 51);
            this.lbl_title2.TabIndex = 3;
            this.lbl_title2.Text = "System";
            // 
            // lbl_title1
            // 
            this.lbl_title1.AutoSize = true;
            this.lbl_title1.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.lbl_title1.Location = new System.Drawing.Point(36, 128);
            this.lbl_title1.Name = "lbl_title1";
            this.lbl_title1.Size = new System.Drawing.Size(249, 51);
            this.lbl_title1.TabIndex = 2;
            this.lbl_title1.Text = "Management";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.panel2.Location = new System.Drawing.Point(488, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.panel3.Location = new System.Drawing.Point(488, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 10;
            // 
            // tb_psw
            // 
            this.tb_psw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.tb_psw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_psw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_psw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.tb_psw.Location = new System.Drawing.Point(488, 124);
            this.tb_psw.Name = "tb_psw";
            this.tb_psw.PasswordChar = '•';
            this.tb_psw.Size = new System.Drawing.Size(300, 27);
            this.tb_psw.TabIndex = 9;
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warning.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_warning.Location = new System.Drawing.Point(528, 315);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(63, 23);
            this.lbl_warning.TabIndex = 11;
            this.lbl_warning.Text = "default";
            this.lbl_warning.Visible = false;
            // 
            // lbl_forget
            // 
            this.lbl_forget.AutoSize = true;
            this.lbl_forget.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forget.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_forget.Location = new System.Drawing.Point(651, 194);
            this.lbl_forget.Name = "lbl_forget";
            this.lbl_forget.Size = new System.Drawing.Size(117, 19);
            this.lbl_forget.TabIndex = 5;
            this.lbl_forget.Text = "Forget password?";
            this.lbl_forget.Click += new System.EventHandler(this.lbl_forget_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.lbl_forget);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tb_psw);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.cb_show);
            this.Controls.Add(this.lbl_psw);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.tb_email);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_psw;
        private System.Windows.Forms.CheckBox cb_show;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title2;
        private System.Windows.Forms.Label lbl_title1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_psw;
        private System.Windows.Forms.Label lbl_inf;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.Label lbl_forget;
    }
}

