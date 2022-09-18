
namespace LibraryManagementSystemEF
{
    partial class AdminBook
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
            this.dgw_book = new System.Windows.Forms.DataGridView();
            this.lb_category = new System.Windows.Forms.Label();
            this.tb_page = new System.Windows.Forms.TextBox();
            this.lb_page = new System.Windows.Forms.Label();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.lb_author = new System.Windows.Forms.Label();
            this.tb_bookTitle = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_book)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_book
            // 
            this.dgw_book.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_book.Location = new System.Drawing.Point(547, 12);
            this.dgw_book.Name = "dgw_book";
            this.dgw_book.RowHeadersWidth = 51;
            this.dgw_book.RowTemplate.Height = 24;
            this.dgw_book.Size = new System.Drawing.Size(679, 462);
            this.dgw_book.TabIndex = 0;
            this.dgw_book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_book_CellClick);
            // 
            // lb_category
            // 
            this.lb_category.AutoSize = true;
            this.lb_category.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lb_category.Location = new System.Drawing.Point(39, 242);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(126, 32);
            this.lb_category.TabIndex = 38;
            this.lb_category.Text = "Category:";
            // 
            // tb_page
            // 
            this.tb_page.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_page.Location = new System.Drawing.Point(176, 190);
            this.tb_page.Name = "tb_page";
            this.tb_page.Size = new System.Drawing.Size(316, 34);
            this.tb_page.TabIndex = 37;
            // 
            // lb_page
            // 
            this.lb_page.AutoSize = true;
            this.lb_page.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_page.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lb_page.Location = new System.Drawing.Point(12, 190);
            this.lb_page.Name = "lb_page";
            this.lb_page.Size = new System.Drawing.Size(153, 32);
            this.lb_page.TabIndex = 36;
            this.lb_page.Text = "Page Count:";
            // 
            // tb_author
            // 
            this.tb_author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_author.Location = new System.Drawing.Point(176, 134);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(316, 34);
            this.tb_author.TabIndex = 35;
            // 
            // lb_author
            // 
            this.lb_author.AutoSize = true;
            this.lb_author.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lb_author.Location = new System.Drawing.Point(62, 134);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(103, 32);
            this.lb_author.TabIndex = 34;
            this.lb_author.Text = "Author:";
            // 
            // tb_bookTitle
            // 
            this.tb_bookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bookTitle.Location = new System.Drawing.Point(176, 80);
            this.tb_bookTitle.Name = "tb_bookTitle";
            this.tb_bookTitle.Size = new System.Drawing.Size(316, 34);
            this.tb_bookTitle.TabIndex = 33;
            // 
            // tb_title
            // 
            this.tb_title.AutoSize = true;
            this.tb_title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.tb_title.Location = new System.Drawing.Point(11, 80);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(154, 32);
            this.tb_title.TabIndex = 32;
            this.tb_title.Text = "Book Name:";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_add.Location = new System.Drawing.Point(18, 354);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 51);
            this.btn_add.TabIndex = 40;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_update.Location = new System.Drawing.Point(176, 354);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(131, 51);
            this.btn_update.TabIndex = 41;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_delete.Location = new System.Drawing.Point(385, 354);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 51);
            this.btn_delete.TabIndex = 42;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btn_back.Location = new System.Drawing.Point(18, 423);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 51);
            this.btn_back.TabIndex = 43;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(176, 28);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(316, 34);
            this.tb_ID.TabIndex = 45;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_id.Location = new System.Drawing.Point(52, 28);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(113, 32);
            this.lbl_id.TabIndex = 44;
            this.lbl_id.Text = "Book ID:";
            // 
            // tb_stock
            // 
            this.tb_stock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stock.Location = new System.Drawing.Point(176, 292);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(68, 34);
            this.tb_stock.TabIndex = 47;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_Stock.Location = new System.Drawing.Point(81, 294);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(84, 32);
            this.lbl_Stock.TabIndex = 46;
            this.lbl_Stock.Text = "Stock:";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantity.Location = new System.Drawing.Point(424, 293);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(68, 34);
            this.tb_quantity.TabIndex = 49;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lbl_quantity.Location = new System.Drawing.Point(287, 293);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(121, 32);
            this.lbl_quantity.TabIndex = 48;
            this.lbl_quantity.Text = "Quantity:";
            // 
            // cb_cat
            // 
            this.cb_cat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Location = new System.Drawing.Point(176, 238);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(316, 36);
            this.cb_cat.TabIndex = 50;
            // 
            // AdminBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(1238, 486);
            this.Controls.Add(this.cb_cat);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.tb_stock);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_category);
            this.Controls.Add(this.tb_page);
            this.Controls.Add(this.lb_page);
            this.Controls.Add(this.tb_author);
            this.Controls.Add(this.lb_author);
            this.Controls.Add(this.tb_bookTitle);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.dgw_book);
            this.Name = "AdminBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminBook_FormClosing);
            this.Load += new System.EventHandler(this.AdminBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_book;
        private System.Windows.Forms.Label lb_category;
        private System.Windows.Forms.TextBox tb_page;
        private System.Windows.Forms.Label lb_page;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label lb_author;
        private System.Windows.Forms.TextBox tb_bookTitle;
        private System.Windows.Forms.Label tb_title;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.ComboBox cb_cat;
    }
}