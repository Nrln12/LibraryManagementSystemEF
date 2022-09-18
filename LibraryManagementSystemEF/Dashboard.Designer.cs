
namespace LibraryManagementSystemEF
{
    partial class Dashboard
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
            this.dgw_dashboard = new System.Windows.Forms.DataGridView();
            this.lbl_book = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_update = new System.Windows.Forms.Label();
            this.lbl_inf = new System.Windows.Forms.Label();
            this.lbl_borrow = new System.Windows.Forms.Label();
            this.lbl_newpsw = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.tb_newpsw = new System.Windows.Forms.TextBox();
            this.lbl_logout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_dashboard)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_dashboard
            // 
            this.dgw_dashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_dashboard.Location = new System.Drawing.Point(23, 80);
            this.dgw_dashboard.Name = "dgw_dashboard";
            this.dgw_dashboard.RowHeadersWidth = 51;
            this.dgw_dashboard.RowTemplate.Height = 24;
            this.dgw_dashboard.Size = new System.Drawing.Size(777, 195);
            this.dgw_dashboard.TabIndex = 0;
            // 
            // lbl_book
            // 
            this.lbl_book.AutoSize = true;
            this.lbl_book.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_book.Location = new System.Drawing.Point(17, 19);
            this.lbl_book.Name = "lbl_book";
            this.lbl_book.Size = new System.Drawing.Size(73, 32);
            this.lbl_book.TabIndex = 3;
            this.lbl_book.Text = "Book";
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.White;
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(73)))), ((int)(((byte)(52)))));
            this.tb_search.Location = new System.Drawing.Point(96, 24);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(535, 27);
            this.tb_search.TabIndex = 9;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_search.Location = new System.Drawing.Point(637, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(163, 34);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_logout);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.lbl_update);
            this.panel1.Controls.Add(this.lbl_inf);
            this.panel1.Controls.Add(this.lbl_borrow);
            this.panel1.Location = new System.Drawing.Point(806, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 253);
            this.panel1.TabIndex = 12;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_name.Location = new System.Drawing.Point(15, 11);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(82, 32);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name";
            // 
            // lbl_update
            // 
            this.lbl_update.AutoSize = true;
            this.lbl_update.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_update.Location = new System.Drawing.Point(15, 108);
            this.lbl_update.Name = "lbl_update";
            this.lbl_update.Size = new System.Drawing.Size(215, 32);
            this.lbl_update.TabIndex = 6;
            this.lbl_update.Text = "Change Password";
            this.lbl_update.Click += new System.EventHandler(this.lbl_update_Click);
            // 
            // lbl_inf
            // 
            this.lbl_inf.AutoSize = true;
            this.lbl_inf.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_inf.Location = new System.Drawing.Point(15, 58);
            this.lbl_inf.Name = "lbl_inf";
            this.lbl_inf.Size = new System.Drawing.Size(166, 32);
            this.lbl_inf.TabIndex = 5;
            this.lbl_inf.Text = "Personal info";
            this.lbl_inf.Click += new System.EventHandler(this.lbl_inf_Click);
            // 
            // lbl_borrow
            // 
            this.lbl_borrow.AutoSize = true;
            this.lbl_borrow.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_borrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_borrow.Location = new System.Drawing.Point(15, 158);
            this.lbl_borrow.Name = "lbl_borrow";
            this.lbl_borrow.Size = new System.Drawing.Size(164, 32);
            this.lbl_borrow.TabIndex = 4;
            this.lbl_borrow.Text = "Borrow book";
            this.lbl_borrow.Click += new System.EventHandler(this.lbl_borrow_Click);
            // 
            // lbl_newpsw
            // 
            this.lbl_newpsw.AutoSize = true;
            this.lbl_newpsw.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newpsw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_newpsw.Location = new System.Drawing.Point(27, 295);
            this.lbl_newpsw.Name = "lbl_newpsw";
            this.lbl_newpsw.Size = new System.Drawing.Size(182, 32);
            this.lbl_newpsw.TabIndex = 14;
            this.lbl_newpsw.Text = "New password";
            this.lbl_newpsw.Visible = false;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_change.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_change.Location = new System.Drawing.Point(498, 295);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(163, 34);
            this.btn_change.TabIndex = 16;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Visible = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // tb_newpsw
            // 
            this.tb_newpsw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_newpsw.Location = new System.Drawing.Point(212, 295);
            this.tb_newpsw.Name = "tb_newpsw";
            this.tb_newpsw.Size = new System.Drawing.Size(280, 34);
            this.tb_newpsw.TabIndex = 17;
            this.tb_newpsw.Visible = false;
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_logout.Location = new System.Drawing.Point(15, 202);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(103, 32);
            this.lbl_logout.TabIndex = 8;
            this.lbl_logout.Text = "Log out";
            this.lbl_logout.Click += new System.EventHandler(this.lbl_logout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1104, 376);
            this.Controls.Add(this.tb_newpsw);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.lbl_newpsw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lbl_book);
            this.Controls.Add(this.dgw_dashboard);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_dashboard)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_dashboard;
        private System.Windows.Forms.Label lbl_book;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_update;
        private System.Windows.Forms.Label lbl_inf;
        private System.Windows.Forms.Label lbl_borrow;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_newpsw;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox tb_newpsw;
        private System.Windows.Forms.Label lbl_logout;
    }
}