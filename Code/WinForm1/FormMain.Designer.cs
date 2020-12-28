namespace WinForm1
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phuongTrinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTBậc1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTBậc2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinhHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinhTronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLýSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phuongTrinhToolStripMenuItem,
            this.hinhHocToolStripMenuItem,
            this.sinhViênToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // phuongTrinhToolStripMenuItem
            // 
            this.phuongTrinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pTBậc1ToolStripMenuItem,
            this.pTBậc2ToolStripMenuItem});
            this.phuongTrinhToolStripMenuItem.Name = "phuongTrinhToolStripMenuItem";
            this.phuongTrinhToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.phuongTrinhToolStripMenuItem.Text = "Phuong Trinh ";
            // 
            // pTBậc1ToolStripMenuItem
            // 
            this.pTBậc1ToolStripMenuItem.Name = "pTBậc1ToolStripMenuItem";
            this.pTBậc1ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pTBậc1ToolStripMenuItem.Text = "PT Bậc 1";
            this.pTBậc1ToolStripMenuItem.Click += new System.EventHandler(this.pTBậc1ToolStripMenuItem_Click);
            // 
            // pTBậc2ToolStripMenuItem
            // 
            this.pTBậc2ToolStripMenuItem.Name = "pTBậc2ToolStripMenuItem";
            this.pTBậc2ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pTBậc2ToolStripMenuItem.Text = "PT Bậc 2";
            this.pTBậc2ToolStripMenuItem.Click += new System.EventHandler(this.pTBậc2ToolStripMenuItem_Click);
            // 
            // hinhHocToolStripMenuItem
            // 
            this.hinhHocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinhTronToolStripMenuItem});
            this.hinhHocToolStripMenuItem.Name = "hinhHocToolStripMenuItem";
            this.hinhHocToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.hinhHocToolStripMenuItem.Text = "Hinh Hoc";
            // 
            // hinhTronToolStripMenuItem
            // 
            this.hinhTronToolStripMenuItem.Name = "hinhTronToolStripMenuItem";
            this.hinhTronToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.hinhTronToolStripMenuItem.Text = "Hinh Tròn";
            this.hinhTronToolStripMenuItem.Click += new System.EventHandler(this.hinhTronToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLýSinhVienToolStripMenuItem});
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.sinhViênToolStripMenuItem.Text = "Sinh Viên";
            // 
            // quanLýSinhVienToolStripMenuItem
            // 
            this.quanLýSinhVienToolStripMenuItem.Name = "quanLýSinhVienToolStripMenuItem";
            this.quanLýSinhVienToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quanLýSinhVienToolStripMenuItem.Text = "Quản Lý Sinh Vien";
            this.quanLýSinhVienToolStripMenuItem.Click += new System.EventHandler(this.quanLýSinhVienToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 312);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phuongTrinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pTBậc1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pTBậc2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinhHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinhTronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLýSinhVienToolStripMenuItem;
    }
}