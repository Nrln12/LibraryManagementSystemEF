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
    public partial class AdminBook : Form
    {
        public AdminBook()
        {
            db = new DB_LibraryEntities();
            InitializeComponent();
        }

        readonly DB_LibraryEntities db;
        public void DGW_Load()
        {
            var book = (from b in db.TBL_Book
                        join c in db.TBL_Category on b.Category equals c.CategoryID
                        orderby b.Book_ID
                        select new
                        {
                            b.Book_ID,
                            b.Title,
                            b.Author,
                            b.Stock,
                            c.CategoryName,
                            b.Quantity,
                            b.Page_Count
                        });
            dgw_book.DataSource = book.ToList();
            cb_cat.DataSource = db.TBL_Category.ToList();
            cb_cat.DisplayMember = "CategoryName";
            cb_cat.ValueMember = "CategoryID";
        }
        private void AdminBook_Load(object sender, EventArgs e)
        {
            DGW_Load();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgw_book.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to change values?", "Confirm",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dgw_book.SelectedCells[0].Value);
                    var book = db.TBL_Book.Find(ID);
                    book.Author = tb_author.Text;
                    int cat = Convert.ToInt32(cb_cat.SelectedValue);
                    book.Category = cat;
                    book.Title = tb_bookTitle.Text;
                    book.Quantity = Convert.ToInt32(tb_quantity.Text);
                    book.Stock = Convert.ToInt32(tb_stock.Text);
                    book.Page_Count = Convert.ToInt32(tb_page.Text);
                    db.SaveChanges();
                    DGW_Load();
                    
                }
            }
            else
            {
                MessageBox.Show("Please select row to update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgw_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tb_ID.Text = dgw_book.SelectedCells[0].Value.ToString();
            tb_bookTitle.Text = dgw_book.SelectedCells[1].Value.ToString();
            tb_author.Text = dgw_book.SelectedCells[2].Value.ToString();
            tb_stock.Text = dgw_book.SelectedCells[3].Value.ToString();
            cb_cat.Text = dgw_book.SelectedCells[4].Value.ToString();
            tb_quantity.Text = dgw_book.SelectedCells[5].Value.ToString();
            tb_page.Text = dgw_book.SelectedCells[6].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are sure to delete item?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgw_book.SelectedCells[0].Value);
                var book = db.TBL_Book.Find(id);
                db.TBL_Book.Remove(book);
                db.SaveChanges();
                DGW_Load();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to add item?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                db.TBL_Book.Add(new TBL_Book
                {
                    Title = tb_bookTitle.Text,
                    Author = tb_author.Text,
                    Page_Count = Convert.ToInt32(tb_page.Text),
                    Quantity = Convert.ToInt32(tb_quantity.Text),
                    Stock = Convert.ToInt32(tb_stock.Text),
                    Category = (int)cb_cat.SelectedValue
                });
                db.SaveChanges();
                DGW_Load();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AdminBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }

    
    
}
