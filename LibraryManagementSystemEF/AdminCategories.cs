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
    public partial class AdminCategories : Form
    {
        public AdminCategories()
        {
            InitializeComponent();
            db = new DB_LibraryEntities();
        }
        readonly DB_LibraryEntities db;
       
      
        private void AdminCategories_Load(object sender, EventArgs e)
        {
            dgw_cats.DataSource = db.TBL_Category.ToList();
            dgw_cats.Columns[2].Visible = false;
            cb_cat.DataSource = db.TBL_Category.ToList();
            cb_cat.ValueMember = "CategoryID";
            cb_cat.DisplayMember = "CategoryName";
            tb_ID.ReadOnly = true;
        }

        private void dgw_cats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_ID.Text = dgw_cats.SelectedCells[0].Value.ToString();
            cb_cat.Text = dgw_cats.SelectedCells[1].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete selected item?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                TBL_Category category = new TBL_Category();
                category.CategoryName = cb_cat.Text;
                db.TBL_Category.Add(category);
                db.SaveChanges();
                dgw_cats.Refresh();
            }
                
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete selected item?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                var cat = db.TBL_Category.Find((int)dgw_cats.SelectedCells[0].Value);
                db.TBL_Category.Remove(cat);
                db.SaveChanges();
                dgw_cats.Refresh();
            }
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete selected item?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                var cat = db.TBL_Category.Find((int)dgw_cats.SelectedCells[0].Value);
                cat.CategoryName = cb_cat.Text;
                db.SaveChanges();
                dgw_cats.Refresh();
            }
                
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
