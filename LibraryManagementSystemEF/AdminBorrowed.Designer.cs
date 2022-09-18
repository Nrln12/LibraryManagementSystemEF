
namespace LibraryManagementSystemEF
{
    partial class AdminBorrowed
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
            this.lbl_book = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.dgw_brwd = new System.Windows.Forms.DataGridView();
            this.dtp_return = new System.Windows.Forms.DateTimePicker();
            this.lb_returnDate = new System.Windows.Forms.Label();
            this.dtp_borrow = new System.Windows.Forms.DateTimePicker();
            this.lb_bDate = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cb_book = new System.Windows.Forms.ComboBox();
            this.cb_user = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_brwd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_book
            // 
            this.lbl_book.AutoSize = true;
            this.lbl_book.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_book.Location = new System.Drawing.Point(86, 28);
            this.lbl_book.Name = "lbl_book";
            this.lbl_book.Size = new System.Drawing.Size(81, 32);
            this.lbl_book.TabIndex = 63;
            this.lbl_book.Text = "Book:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_back.Location = new System.Drawing.Point(14, 384);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 51);
            this.btn_back.TabIndex = 62;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_delete.Location = new System.Drawing.Point(371, 293);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 51);
            this.btn_delete.TabIndex = 61;
            this.btn_delete.Text = "Return ";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_update.Location = new System.Drawing.Point(178, 293);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(131, 51);
            this.btn_update.TabIndex = 60;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_add.Location = new System.Drawing.Point(14, 293);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 51);
            this.btn_add.TabIndex = 59;
            this.btn_add.Text = "Borrow";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_UserID.Location = new System.Drawing.Point(86, 82);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(74, 32);
            this.lbl_UserID.TabIndex = 51;
            this.lbl_UserID.Text = "User:";
            // 
            // dgw_brwd
            // 
            this.dgw_brwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_brwd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_brwd.Location = new System.Drawing.Point(529, 28);
            this.dgw_brwd.Name = "dgw_brwd";
            this.dgw_brwd.RowHeadersWidth = 51;
            this.dgw_brwd.RowTemplate.Height = 24;
            this.dgw_brwd.Size = new System.Drawing.Size(728, 407);
            this.dgw_brwd.TabIndex = 50;
            this.dgw_brwd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_brwd_CellClick);
            // 
            // dtp_return
            // 
            this.dtp_return.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtp_return.Location = new System.Drawing.Point(178, 183);
            this.dtp_return.Name = "dtp_return";
            this.dtp_return.Size = new System.Drawing.Size(316, 34);
            this.dtp_return.TabIndex = 68;
            // 
            // lb_returnDate
            // 
            this.lb_returnDate.AutoSize = true;
            this.lb_returnDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_returnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lb_returnDate.Location = new System.Drawing.Point(8, 183);
            this.lb_returnDate.Name = "lb_returnDate";
            this.lb_returnDate.Size = new System.Drawing.Size(159, 32);
            this.lb_returnDate.TabIndex = 67;
            this.lb_returnDate.Text = "Return Date:";
            // 
            // dtp_borrow
            // 
            this.dtp_borrow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtp_borrow.Location = new System.Drawing.Point(178, 129);
            this.dtp_borrow.Name = "dtp_borrow";
            this.dtp_borrow.Size = new System.Drawing.Size(316, 34);
            this.dtp_borrow.TabIndex = 66;
            // 
            // lb_bDate
            // 
            this.lb_bDate.AutoSize = true;
            this.lb_bDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lb_bDate.Location = new System.Drawing.Point(1, 131);
            this.lb_bDate.Name = "lb_bDate";
            this.lb_bDate.Size = new System.Drawing.Size(166, 32);
            this.lb_bDate.TabIndex = 65;
            this.lb_bDate.Text = "Borrow Date:";
            // 
            // tbStatus
            // 
            this.tbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatus.Location = new System.Drawing.Point(178, 232);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(316, 34);
            this.tbStatus.TabIndex = 72;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_status.Location = new System.Drawing.Point(76, 232);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(91, 32);
            this.lbl_status.TabIndex = 71;
            this.lbl_status.Text = "Status:";
            // 
            // cb_book
            // 
            this.cb_book.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_book.FormattingEnabled = true;
            this.cb_book.Location = new System.Drawing.Point(178, 24);
            this.cb_book.Name = "cb_book";
            this.cb_book.Size = new System.Drawing.Size(316, 36);
            this.cb_book.TabIndex = 73;
            // 
            // cb_user
            // 
            this.cb_user.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_user.FormattingEnabled = true;
            this.cb_user.Location = new System.Drawing.Point(178, 78);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(316, 36);
            this.cb_user.TabIndex = 74;
            // 
            // AdminBorrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1269, 468);
            this.Controls.Add(this.cb_user);
            this.Controls.Add(this.cb_book);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.dtp_return);
            this.Controls.Add(this.lb_returnDate);
            this.Controls.Add(this.dtp_borrow);
            this.Controls.Add(this.lb_bDate);
            this.Controls.Add(this.lbl_book);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_UserID);
            this.Controls.Add(this.dgw_brwd);
            this.Name = "AdminBorrowed";
            this.Text = "AdminBorrowed";
            this.Load += new System.EventHandler(this.AdminBorrowed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_brwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_book;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.DataGridView dgw_brwd;
        private System.Windows.Forms.DateTimePicker dtp_return;
        private System.Windows.Forms.Label lb_returnDate;
        private System.Windows.Forms.DateTimePicker dtp_borrow;
        private System.Windows.Forms.Label lb_bDate;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox cb_book;
        private System.Windows.Forms.ComboBox cb_user;
    }
}