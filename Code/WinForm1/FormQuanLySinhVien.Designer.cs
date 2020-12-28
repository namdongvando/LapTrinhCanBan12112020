namespace WinForm1
{
    partial class FormQuanLySinhVien
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
            this.dgvDanhSachSV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachSV
            // 
            this.dgvDanhSachSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSV.Location = new System.Drawing.Point(220, 12);
            this.dgvDanhSachSV.Name = "dgvDanhSachSV";
            this.dgvDanhSachSV.Size = new System.Drawing.Size(568, 426);
            this.dgvDanhSachSV.TabIndex = 0;
            this.dgvDanhSachSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(12, 41);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(186, 20);
            this.txtMaSV.TabIndex = 2;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(12, 86);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(186, 20);
            this.txtTenSV.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Sinh Viên";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(12, 131);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(186, 20);
            this.txtSDT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SĐT";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(12, 175);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(186, 82);
            this.txtDiaChi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(12, 287);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(186, 20);
            this.dtpNgaySinh.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 357);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(53, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachSV);
            this.Name = "FormQuanLySinhVien";
            this.Text = "FormQuanLySinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}