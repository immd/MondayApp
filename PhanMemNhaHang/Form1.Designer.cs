namespace PhanMemNhaHang
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCACEL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grd_pick = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnpick = new System.Windows.Forms.Button();
            this.btnUnpick = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mondayDataSet4 = new PhanMemNhaHang.MondayDataSet4();
            this.mondayDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd_pick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondayDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondayDataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(505, 343);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCACEL
            // 
            this.btnCACEL.Location = new System.Drawing.Point(586, 343);
            this.btnCACEL.Name = "btnCACEL";
            this.btnCACEL.Size = new System.Drawing.Size(75, 23);
            this.btnCACEL.TabIndex = 1;
            this.btnCACEL.Text = "CANCEL";
            this.btnCACEL.UseVisualStyleBackColor = true;
            this.btnCACEL.Click += new System.EventHandler(this.btnCACEL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng cộng:";
            // 
            // txtsum
            // 
            this.txtsum.Location = new System.Drawing.Point(505, 317);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(156, 20);
            this.txtsum.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm món mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(296, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa món";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grd_pick
            // 
            this.grd_pick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_pick.Location = new System.Drawing.Point(0, 27);
            this.grd_pick.Name = "grd_pick";
            this.grd_pick.Size = new System.Drawing.Size(397, 334);
            this.grd_pick.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(142, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa món";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnpick
            // 
            this.btnpick.Location = new System.Drawing.Point(0, 367);
            this.btnpick.Name = "btnpick";
            this.btnpick.Size = new System.Drawing.Size(101, 23);
            this.btnpick.TabIndex = 13;
            this.btnpick.Text = "Chọn món";
            this.btnpick.UseVisualStyleBackColor = true;
            this.btnpick.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUnpick
            // 
            this.btnUnpick.Location = new System.Drawing.Point(142, 367);
            this.btnUnpick.Name = "btnUnpick";
            this.btnUnpick.Size = new System.Drawing.Size(101, 23);
            this.btnUnpick.TabIndex = 14;
            this.btnUnpick.Text = "Bỏ chọn";
            this.btnUnpick.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.mondayDataSet4BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(403, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 284);
            this.dataGridView1.TabIndex = 15;
            // 
            // mondayDataSet4
            // 
            this.mondayDataSet4.DataSetName = "MondayDataSet4";
            this.mondayDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mondayDataSet4BindingSource
            // 
            this.mondayDataSet4BindingSource.DataSource = this.mondayDataSet4;
            this.mondayDataSet4BindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUnpick);
            this.Controls.Add(this.btnpick);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grd_pick);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtsum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCACEL);
            this.Controls.Add(this.btnOK);
            this.Name = "Form1";
            this.Text = "Chọn Món";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_pick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondayDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondayDataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCACEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView grd_pick;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnpick;
        private System.Windows.Forms.Button btnUnpick;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mondayDataSet4BindingSource;
        private MondayDataSet4 mondayDataSet4;
    }
}

