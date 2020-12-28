namespace WinForm1
{
    partial class FormHinhTron
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBanKinh = new System.Windows.Forms.Label();
            this.lblChuVi = new System.Windows.Forms.Label();
            this.lblDienTich = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bán Kính";
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(38, 46);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(131, 20);
            this.txtBanKinh.TabIndex = 1;
            this.txtBanKinh.TextChanged += new System.EventHandler(this.txtBanKinh_TextChanged);
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(38, 93);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.Size = new System.Drawing.Size(131, 20);
            this.txtChuVi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chu Vi";
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(38, 143);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(131, 20);
            this.txtDienTich.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diện Tích";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(38, 184);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 6;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinForm1.Properties.Resources.HinhTron;
            this.pictureBox1.Location = new System.Drawing.Point(215, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblBanKinh
            // 
            this.lblBanKinh.AutoSize = true;
            this.lblBanKinh.Location = new System.Drawing.Point(399, 150);
            this.lblBanKinh.Name = "lblBanKinh";
            this.lblBanKinh.Size = new System.Drawing.Size(22, 13);
            this.lblBanKinh.TabIndex = 8;
            this.lblBanKinh.Text = "r = ";
            // 
            // lblChuVi
            // 
            this.lblChuVi.AutoSize = true;
            this.lblChuVi.Location = new System.Drawing.Point(289, 77);
            this.lblChuVi.Name = "lblChuVi";
            this.lblChuVi.Size = new System.Drawing.Size(44, 13);
            this.lblChuVi.TabIndex = 9;
            this.lblChuVi.Text = "Chu Vi :";
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(289, 223);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(58, 13);
            this.lblDienTich.TabIndex = 10;
            this.lblDienTich.Text = "Diện Tích:";
            // 
            // FormHinhTron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 376);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.lblChuVi);
            this.Controls.Add(this.lblBanKinh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.label1);
            this.Name = "FormHinhTron";
            this.Text = "FormHinhTron";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBanKinh;
        private System.Windows.Forms.Label lblChuVi;
        private System.Windows.Forms.Label lblDienTich;
    }
}