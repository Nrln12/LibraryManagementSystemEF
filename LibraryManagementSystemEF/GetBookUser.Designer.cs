
namespace LibraryManagementSystemEF
{
    partial class GetBookUser
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
            this.tb_bookTitle = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.Label();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.lb_author = new System.Windows.Forms.Label();
            this.tb_page = new System.Windows.Forms.TextBox();
            this.lb_page = new System.Windows.Forms.Label();
            this.tb_category = new System.Windows.Forms.TextBox();
            this.lb_category = new System.Windows.Forms.Label();
            this.lb_bDate = new System.Windows.Forms.Label();
            this.dtp_borrow = new System.Windows.Forms.DateTimePicker();
            this.dtp_return = new System.Windows.Forms.DateTimePicker();
            this.lb_returnDate = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_bookTitle
            // 
            this.tb_bookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bookTitle.Location = new System.Drawing.Point(197, 30);
            this.tb_bookTitle.Name = "tb_bookTitle";
            this.tb_bookTitle.ReadOnly = true;
            this.tb_bookTitle.Size = new System.Drawing.Size(316, 34);
            this.tb_bookTitle.TabIndex = 19;
            // 
            // tb_title
            // 
            this.tb_title.AutoSize = true;
            this.tb_title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.tb_title.Location = new System.Drawing.Point(33, 30);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(154, 32);
            this.tb_title.TabIndex = 18;
            this.tb_title.Text = "Book Name:";
            // 
            // tb_author
            // 
            this.tb_author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_author.Location = new System.Drawing.Point(197, 84);
            this.tb_author.Name = "tb_author";
            this.tb_author.ReadOnly = true;
            this.tb_author.Size = new System.Drawing.Size(316, 34);
            this.tb_author.TabIndex = 21;
            // 
            // lb_author
            // 
            this.lb_author.AutoSize = true;
            this.lb_author.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lb_author.Location = new System.Drawing.Point(33, 84);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(103, 32);
            this.lb_author.TabIndex = 20;
            this.lb_author.Text = "Author:";
            // 
            // tb_page
            // 
            this.tb_page.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_page.Location = new System.Drawing.Point(197, 140);
            this.tb_page.Name = "tb_page";
            this.tb_page.ReadOnly = true;
            this.tb_page.Size = new System.Drawing.Size(316, 34);
            this.tb_page.TabIndex = 23;
            // 
            // lb_page
            // 
            this.lb_page.AutoSize = true;
            this.lb_page.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_page.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lb_page.Location = new System.Drawing.Point(33, 140);
            this.lb_page.Name = "lb_page";
            this.lb_page.Size = new System.Drawing.Size(153, 32);
            this.lb_page.TabIndex = 22;
            this.lb_page.Text = "Page Count:";
            // 
            // tb_category
            // 
            this.tb_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_category.Location = new System.Drawing.Point(197, 192);
            this.tb_category.Name = "tb_category";
            this.tb_category.ReadOnly = true;
            this.tb_category.Size = new System.Drawing.Size(316, 34);
            this.tb_category.TabIndex = 25;
            // 
            // lb_category
            // 
            this.lb_category.AutoSize = true;
            this.lb_category.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lb_category.Location = new System.Drawing.Point(33, 192);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(126, 32);
            this.lb_category.TabIndex = 24;
            this.lb_category.Text = "Category:";
            // 
            // lb_bDate
            // 
            this.lb_bDate.AutoSize = true;
            this.lb_bDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lb_bDate.Location = new System.Drawing.Point(33, 247);
            this.lb_bDate.Name = "lb_bDate";
            this.lb_bDate.Size = new System.Drawing.Size(166, 32);
            this.lb_bDate.TabIndex = 26;
            this.lb_bDate.Text = "Borrow Date:";
            // 
            // dtp_borrow
            // 
            this.dtp_borrow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtp_borrow.Location = new System.Drawing.Point(197, 245);
            this.dtp_borrow.Name = "dtp_borrow";
            this.dtp_borrow.Size = new System.Drawing.Size(316, 34);
            this.dtp_borrow.TabIndex = 29;
            // 
            // dtp_return
            // 
            this.dtp_return.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtp_return.Location = new System.Drawing.Point(197, 299);
            this.dtp_return.Name = "dtp_return";
            this.dtp_return.Size = new System.Drawing.Size(316, 34);
            this.dtp_return.TabIndex = 31;
            // 
            // lb_returnDate
            // 
            this.lb_returnDate.AutoSize = true;
            this.lb_returnDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_returnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lb_returnDate.Location = new System.Drawing.Point(33, 301);
            this.lb_returnDate.Name = "lb_returnDate";
            this.lb_returnDate.Size = new System.Drawing.Size(159, 32);
            this.lb_returnDate.TabIndex = 30;
            this.lb_returnDate.Text = "Return Date:";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(73)))), ((int)(((byte)(52)))));
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.btn_confirm.Location = new System.Drawing.Point(403, 352);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(110, 41);
            this.btn_confirm.TabIndex = 32;
            this.btn_confirm.Text = "Borrow";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(73)))), ((int)(((byte)(52)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.btn_back.Location = new System.Drawing.Point(197, 352);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(110, 41);
            this.btn_back.TabIndex = 33;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(569, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 344);
            this.dataGridView1.TabIndex = 34;
            // 
            // GetBookUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1244, 456);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.dtp_return);
            this.Controls.Add(this.lb_returnDate);
            this.Controls.Add(this.dtp_borrow);
            this.Controls.Add(this.lb_bDate);
            this.Controls.Add(this.tb_category);
            this.Controls.Add(this.lb_category);
            this.Controls.Add(this.tb_page);
            this.Controls.Add(this.lb_page);
            this.Controls.Add(this.tb_author);
            this.Controls.Add(this.lb_author);
            this.Controls.Add(this.tb_bookTitle);
            this.Controls.Add(this.tb_title);
            this.Name = "GetBookUser";
            this.Text = "GetBookUser";
            this.Load += new System.EventHandler(this.GetBookUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_bookTitle;
        private System.Windows.Forms.Label tb_title;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label lb_author;
        private System.Windows.Forms.TextBox tb_page;
        private System.Windows.Forms.Label lb_page;
        private System.Windows.Forms.TextBox tb_category;
        private System.Windows.Forms.Label lb_category;
        private System.Windows.Forms.Label lb_bDate;
        private System.Windows.Forms.DateTimePicker dtp_borrow;
        private System.Windows.Forms.DateTimePicker dtp_return;
        private System.Windows.Forms.Label lb_returnDate;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}