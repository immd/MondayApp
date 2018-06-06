using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemNhaHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void ShowProductList()
        {
            var db = new MondayEntities();
            var list = db.sanphams.ToList();
            this.grd_pick.DataSource = list;
            this.grd_pick.Columns["id"].Visible = false; // hide the id column
            this.grd_pick.Columns["Product"].Visible = false; // hide column


        }
        

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            var form = new FormAdd();
            form.ShowDialog();
            this.ShowProductList();
        }
        private void btnCACEL_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var db = new MondayEntities();
            if (MessageBox.Show("Do you want to delete", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < this.grd_pick.SelectedRows.Count; i++)
                {
                    var row = this.grd_pick.SelectedRows[i];
                    var item = (sanpham)row.DataBoundItem;

                    try
                    {
                        sanpham sp = db.sanphams.Find(item.id);
                        db.sanphams.Remove(sp);
                        db.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot deletclass: " + item.id);
                    }
                    this.ShowProductList();


                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowProductList();
        }

        

        private void grdBlock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.grd_pick.SelectedRows.Count == 1)
            {
                var row = this.grd_pick.SelectedRows[0];
                var item = (sanpham)row.DataBoundItem;
                var form = new FormEdit(item);
                form.ShowDialog();
                this.ShowProductList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.grd_pick.SelectedRows.Count == 1)
            {
                var row = this.grdBlock.SelectedRows[0];
                var item = (sanpham)row.DataBoundItem;
                //var form = new FormEdit(item);
                // form.ShowDialog();
                this.ShowProductList();
            }
        }
    }


}
