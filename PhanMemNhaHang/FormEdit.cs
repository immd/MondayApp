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
    public partial class FormEdit : Form
    {
        

        public FormEdit(sanpham sanpham)
        {
            InitializeComponent();
            this.sanpham = sanpham;
            

        }
        private sanpham sanpham;
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MondayEntities();
                var newSanpham = db.sanphams.Find(this.sanpham.id);
                newSanpham.nameproduct = this.txtName.Text;
                newSanpham.id = int.Parse(this.txtID.Text);
                newSanpham.price = int.Parse(this.TxtPrice.Text);
                newSanpham.soluong = int.Parse(this.txtsoluong.Text);
               
               
                db.Entry(newSanpham).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            
           
            MondayEntities db = new MondayEntities();
            this.sanphamBindingSource.DataSource = db.sanphams.ToList();
            this.sanpham.ValueMember = "id"; // set value column
            this.sanpham.DisplayMember = "Name"; // set display column
            this.txtName.Text = sanpham.nameproduct; 
            this.txtID.Text = sanpham.id.ToString();
            this.TxtPrice.Text = sanpham.price.ToString();
            this.txtsoluong.Text = sanpham.soluong.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

   

        

       

        
}
