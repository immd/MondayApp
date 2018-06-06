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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }
        private void FormAdd_Load(object sender, EventArgs e)
        {
            MondayEntities db = new MondayEntities();
            this.sanphamBindingSource.DataSource = db.sanphams.ToList(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sanpham sanpham = new sanpham();
            sanpham.nameproduct = this.txtName.Text;
            sanpham.price = int.Parse(this.TxtPrice.Text);
            sanpham.soluong = int.Parse(this.txtsoluong.Text);
            sanpham.id = int.Parse(this.txtID.Text);
            



            try
            {
                MondayEntities db = new MondayEntities();
                db.sanphams.Add(sanpham);
                db.SaveChanges();
                this.Close();
                MessageBox.Show("Thêm Sản phẩm Thành Công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
