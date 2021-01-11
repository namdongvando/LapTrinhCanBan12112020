namespace SuDungLinQ
{
    partial class FormHangHoa
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
            this.dgvDanhSachHangHoa = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThemHangHoa = new System.Windows.Forms.Button();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachHangHoa
            // 
            this.dgvDanhSachHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHangHoa.Location = new System.Drawing.Point(12, 56);
            this.dgvDanhSachHangHoa.Name = "dgvDanhSachHangHoa";
            this.dgvDanhSachHangHoa.Size = new System.Drawing.Size(776, 382);
            this.dgvDanhSachHangHoa.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(404, 28);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(39, 23);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(12, 30);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(206, 20);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThemHangHoa
            // 
            this.btnThemHangHoa.Location = new System.Drawing.Point(686, 27);
            this.btnThemHangHoa.Name = "btnThemHangHoa";
            this.btnThemHangHoa.Size = new System.Drawing.Size(102, 23);
            this.btnThemHangHoa.TabIndex = 3;
            this.btnThemHangHoa.Text = "Thêm Hàng Hóa";
            this.btnThemHangHoa.UseVisualStyleBackColor = true;
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(224, 29);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(174, 21);
            this.cbbLoai.TabIndex = 4;
            this.cbbLoai.SelectedIndexChanged += new System.EventHandler(this.cbbLoai_SelectedIndexChanged);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.btnThemHangHoa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvDanhSachHangHoa);
            this.Name = "FormHangHoa";
            this.Text = "FormHangHoa";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachHangHoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThemHangHoa;
        private System.Windows.Forms.ComboBox cbbLoai;
    }
}