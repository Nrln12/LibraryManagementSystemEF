
namespace LibraryManagementSystemEF
{
    partial class AdminUser
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
            this.dgw_user = new System.Windows.Forms.DataGridView();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_last = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_UserID = new System.Windows.Forms.TextBox();
            this.lbl_userID = new System.Windows.Forms.Label();
            this.tb_psw = new System.Windows.Forms.TextBox();
            this.lbl_psw = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_user
            // 
            this.dgw_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_user.Location = new System.Drawing.Point(611, 37);
            this.dgw_user.Name = "dgw_user";
            this.dgw_user.RowHeadersWidth = 51;
            this.dgw_user.RowTemplate.Height = 24;
            this.dgw_user.Size = new System.Drawing.Size(616, 344);
            this.dgw_user.TabIndex = 49;
            this.dgw_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_user_CellClick);
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(239, 199);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(316, 34);
            this.tb_email.TabIndex = 42;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_email.Location = new System.Drawing.Point(75, 201);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(84, 32);
            this.lbl_email.TabIndex = 41;
            this.lbl_email.Text = "Email:";
            // 
            // tb_last
            // 
            this.tb_last.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_last.Location = new System.Drawing.Point(239, 147);
            this.tb_last.Name = "tb_last";
            this.tb_last.Size = new System.Drawing.Size(316, 34);
            this.tb_last.TabIndex = 40;
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_lastname.Location = new System.Drawing.Point(75, 149);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(130, 32);
            this.lbl_lastname.TabIndex = 39;
            this.lbl_lastname.Text = "Lastname:";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(239, 91);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(316, 34);
            this.tb_name.TabIndex = 38;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_name.Location = new System.Drawing.Point(75, 93);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(89, 32);
            this.lbl_name.TabIndex = 37;
            this.lbl_name.Text = "Name:";
            // 
            // tb_UserID
            // 
            this.tb_UserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserID.Location = new System.Drawing.Point(239, 37);
            this.tb_UserID.Name = "tb_UserID";
            this.tb_UserID.Size = new System.Drawing.Size(316, 34);
            this.tb_UserID.TabIndex = 36;
            // 
            // lbl_userID
            // 
            this.lbl_userID.AutoSize = true;
            this.lbl_userID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_userID.Location = new System.Drawing.Point(75, 39);
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.Size = new System.Drawing.Size(106, 32);
            this.lbl_userID.TabIndex = 35;
            this.lbl_userID.Text = "User ID:";
            // 
            // tb_psw
            // 
            this.tb_psw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_psw.Location = new System.Drawing.Point(239, 255);
            this.tb_psw.Name = "tb_psw";
            this.tb_psw.Size = new System.Drawing.Size(316, 34);
            this.tb_psw.TabIndex = 51;
            // 
            // lbl_psw
            // 
            this.lbl_psw.AutoSize = true;
            this.lbl_psw.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_psw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_psw.Location = new System.Drawing.Point(75, 257);
            this.lbl_psw.Name = "lbl_psw";
            this.lbl_psw.Size = new System.Drawing.Size(130, 32);
            this.lbl_psw.TabIndex = 50;
            this.lbl_psw.Text = "Password:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_back.Location = new System.Drawing.Point(81, 386);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 51);
            this.btn_back.TabIndex = 55;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_delete.Location = new System.Drawing.Point(448, 317);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 51);
            this.btn_delete.TabIndex = 54;
            this.btn_delete.Text = "Delete";
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
            this.btn_update.Location = new System.Drawing.Point(239, 317);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(131, 51);
            this.btn_update.TabIndex = 53;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_add.Location = new System.Drawing.Point(81, 317);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 51);
            this.btn_add.TabIndex = 52;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1307, 477);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_psw);
            this.Controls.Add(this.lbl_psw);
            this.Controls.Add(this.dgw_user);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.tb_last);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tb_UserID);
            this.Controls.Add(this.lbl_userID);
            this.Name = "AdminUser";
            this.Text = "AdminUser";
            this.Load += new System.EventHandler(this.AdminUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_user;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_last;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_UserID;
        private System.Windows.Forms.Label lbl_userID;
        private System.Windows.Forms.TextBox tb_psw;
        private System.Windows.Forms.Label lbl_psw;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
    }
}