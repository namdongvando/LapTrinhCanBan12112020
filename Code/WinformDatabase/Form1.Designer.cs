namespace WinformDatabase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eStore20DataSet = new WinformDatabase.eStore20DataSet();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new WinformDatabase.eStore20DataSetTableAdapters.HangHoaTableAdapter();
            this.maHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDonViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLanXemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStore20DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHHDataGridViewTextBoxColumn,
            this.tenHHDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn,
            this.moTaDonViDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.hinhDataGridViewTextBoxColumn,
            this.ngaySXDataGridViewTextBoxColumn,
            this.giamGiaDataGridViewTextBoxColumn,
            this.soLanXemDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.maNCCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hangHoaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // eStore20DataSet
            // 
            this.eStore20DataSet.DataSetName = "eStore20DataSet";
            this.eStore20DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.eStore20DataSet;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // maHHDataGridViewTextBoxColumn
            // 
            this.maHHDataGridViewTextBoxColumn.DataPropertyName = "MaHH";
            this.maHHDataGridViewTextBoxColumn.HeaderText = "MaHH";
            this.maHHDataGridViewTextBoxColumn.Name = "maHHDataGridViewTextBoxColumn";
            this.maHHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenHHDataGridViewTextBoxColumn
            // 
            this.tenHHDataGridViewTextBoxColumn.DataPropertyName = "TenHH";
            this.tenHHDataGridViewTextBoxColumn.HeaderText = "TenHH";
            this.tenHHDataGridViewTextBoxColumn.Name = "tenHHDataGridViewTextBoxColumn";
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            // 
            // moTaDonViDataGridViewTextBoxColumn
            // 
            this.moTaDonViDataGridViewTextBoxColumn.DataPropertyName = "MoTaDonVi";
            this.moTaDonViDataGridViewTextBoxColumn.HeaderText = "MoTaDonVi";
            this.moTaDonViDataGridViewTextBoxColumn.Name = "moTaDonViDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // hinhDataGridViewTextBoxColumn
            // 
            this.hinhDataGridViewTextBoxColumn.DataPropertyName = "Hinh";
            this.hinhDataGridViewTextBoxColumn.HeaderText = "Hinh";
            this.hinhDataGridViewTextBoxColumn.Name = "hinhDataGridViewTextBoxColumn";
            // 
            // ngaySXDataGridViewTextBoxColumn
            // 
            this.ngaySXDataGridViewTextBoxColumn.DataPropertyName = "NgaySX";
            this.ngaySXDataGridViewTextBoxColumn.HeaderText = "NgaySX";
            this.ngaySXDataGridViewTextBoxColumn.Name = "ngaySXDataGridViewTextBoxColumn";
            // 
            // giamGiaDataGridViewTextBoxColumn
            // 
            this.giamGiaDataGridViewTextBoxColumn.DataPropertyName = "GiamGia";
            this.giamGiaDataGridViewTextBoxColumn.HeaderText = "GiamGia";
            this.giamGiaDataGridViewTextBoxColumn.Name = "giamGiaDataGridViewTextBoxColumn";
            // 
            // soLanXemDataGridViewTextBoxColumn
            // 
            this.soLanXemDataGridViewTextBoxColumn.DataPropertyName = "SoLanXem";
            this.soLanXemDataGridViewTextBoxColumn.HeaderText = "SoLanXem";
            this.soLanXemDataGridViewTextBoxColumn.Name = "soLanXemDataGridViewTextBoxColumn";
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "MoTa";
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStore20DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private eStore20DataSet eStore20DataSet;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private eStore20DataSetTableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDonViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLanXemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
    }
}

