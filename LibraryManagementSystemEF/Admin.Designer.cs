
namespace LibraryManagementSystemEF
{
    partial class Admin
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_numBooks = new System.Windows.Forms.Label();
            this.lbl_numReturned = new System.Windows.Forms.Label();
            this.lbl_numCat = new System.Windows.Forms.Label();
            this.lbl_numUsers = new System.Windows.Forms.Label();
            this.lbl_numFined = new System.Windows.Forms.Label();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_numBorrowed = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(82, 32);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name";
            // 
            // lbl_numBooks
            // 
            this.lbl_numBooks.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numBooks.ForeColor = System.Drawing.Color.White;
            this.lbl_numBooks.Location = new System.Drawing.Point(0, 0);
            this.lbl_numBooks.Name = "lbl_numBooks";
            this.lbl_numBooks.Size = new System.Drawing.Size(275, 135);
            this.lbl_numBooks.TabIndex = 5;
            this.lbl_numBooks.Text = "Books: ";
            this.lbl_numBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_numBooks.Click += new System.EventHandler(this.lbl_numBooks_Click);
            // 
            // lbl_numReturned
            // 
            this.lbl_numReturned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_numReturned.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numReturned.ForeColor = System.Drawing.Color.White;
            this.lbl_numReturned.Location = new System.Drawing.Point(763, 66);
            this.lbl_numReturned.Name = "lbl_numReturned";
            this.lbl_numReturned.Size = new System.Drawing.Size(275, 135);
            this.lbl_numReturned.TabIndex = 5;
            this.lbl_numReturned.Text = "Returned books: ";
            this.lbl_numReturned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_numReturned.Click += new System.EventHandler(this.lbl_numReturned_Click);
            // 
            // lbl_numCat
            // 
            this.lbl_numCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.lbl_numCat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numCat.ForeColor = System.Drawing.Color.White;
            this.lbl_numCat.Location = new System.Drawing.Point(39, 245);
            this.lbl_numCat.Name = "lbl_numCat";
            this.lbl_numCat.Size = new System.Drawing.Size(275, 135);
            this.lbl_numCat.TabIndex = 5;
            this.lbl_numCat.Text = "Categories: ";
            this.lbl_numCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_numCat.Click += new System.EventHandler(this.lbl_numCat_Click);
            // 
            // lbl_numUsers
            // 
            this.lbl_numUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
            this.lbl_numUsers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numUsers.ForeColor = System.Drawing.Color.White;
            this.lbl_numUsers.Location = new System.Drawing.Point(395, 245);
            this.lbl_numUsers.Name = "lbl_numUsers";
            this.lbl_numUsers.Size = new System.Drawing.Size(275, 135);
            this.lbl_numUsers.TabIndex = 5;
            this.lbl_numUsers.Text = "Users: ";
            this.lbl_numUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_numUsers.Click += new System.EventHandler(this.lbl_numUsers_Click);
            // 
            // lbl_numFined
            // 
            this.lbl_numFined.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(121)))));
            this.lbl_numFined.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numFined.ForeColor = System.Drawing.Color.White;
            this.lbl_numFined.Location = new System.Drawing.Point(763, 245);
            this.lbl_numFined.Name = "lbl_numFined";
            this.lbl_numFined.Size = new System.Drawing.Size(275, 135);
            this.lbl_numFined.TabIndex = 5;
            this.lbl_numFined.Text = "Fined Users: ";
            this.lbl_numFined.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_numFined.Click += new System.EventHandler(this.lbl_numFined_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_Setting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.btn_Setting.Location = new System.Drawing.Point(914, 403);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(130, 51);
            this.btn_Setting.TabIndex = 9;
            this.btn_Setting.Text = "Settings";
            this.btn_Setting.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.btn_back.Location = new System.Drawing.Point(39, 403);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(130, 51);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.lbl_numBooks);
            this.panel1.Location = new System.Drawing.Point(39, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 135);
            this.panel1.TabIndex = 11;
            // 
            // lbl_numBorrowed
            // 
            this.lbl_numBorrowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(122)))), ((int)(((byte)(95)))));
            this.lbl_numBorrowed.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numBorrowed.ForeColor = System.Drawing.Color.White;
            this.lbl_numBorrowed.Location = new System.Drawing.Point(395, 66);
            this.lbl_numBorrowed.Name = "lbl_numBorrowed";
            this.lbl_numBorrowed.Size = new System.Drawing.Size(275, 135);
            this.lbl_numBorrowed.TabIndex = 5;
            this.lbl_numBorrowed.Text = "Borrowed books: ";
            this.lbl_numBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_numBorrowed.Click += new System.EventHandler(this.lbl_numBorrowed_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1180, 486);
            this.Controls.Add(this.lbl_numFined);
            this.Controls.Add(this.lbl_numUsers);
            this.Controls.Add(this.lbl_numCat);
            this.Controls.Add(this.lbl_numReturned);
            this.Controls.Add(this.lbl_numBorrowed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.lbl_name);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_numBooks;
        private System.Windows.Forms.Label lbl_numReturned;
        private System.Windows.Forms.Label lbl_numCat;
        private System.Windows.Forms.Label lbl_numUsers;
        private System.Windows.Forms.Label lbl_numFined;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_numBorrowed;
    }
}