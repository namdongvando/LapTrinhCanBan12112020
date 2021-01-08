namespace SuDungLinQ
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
            this.dgvDanhSachLoai = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHànhHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoai)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachLoai
            // 
            this.dgvDanhSachLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLoai.Location = new System.Drawing.Point(12, 93);
            this.dgvDanhSachLoai.Name = "dgvDanhSachLoai";
            this.dgvDanhSachLoai.Size = new System.Drawing.Size(776, 345);
            this.dgvDanhSachLoai.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHàngHóaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýHàngHóaToolStripMenuItem
            // 
            this.quảnLýHàngHóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýLoạiToolStripMenuItem,
            this.quảnLýNhàCungCấpToolStripMenuItem,
            this.quảnLýHànhHóaToolStripMenuItem});
            this.quảnLýHàngHóaToolStripMenuItem.Name = "quảnLýHàngHóaToolStripMenuItem";
            this.quảnLýHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.quảnLýHàngHóaToolStripMenuItem.Text = "Quản Lý Hàng Hóa";
            // 
            // quảnLýLoạiToolStripMenuItem
            // 
            this.quảnLýLoạiToolStripMenuItem.Name = "quảnLýLoạiToolStripMenuItem";
            this.quảnLýLoạiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýLoạiToolStripMenuItem.Text = "Loại Hàng Hóa";
            this.quảnLýLoạiToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiToolStripMenuItem_Click);
            // 
            // quảnLýNhàCungCấpToolStripMenuItem
            // 
            this.quảnLýNhàCungCấpToolStripMenuItem.Name = "quảnLýNhàCungCấpToolStripMenuItem";
            this.quảnLýNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýNhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.quảnLýNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhàCungCấpToolStripMenuItem_Click);
            // 
            // quảnLýHànhHóaToolStripMenuItem
            // 
            this.quảnLýHànhHóaToolStripMenuItem.Name = "quảnLýHànhHóaToolStripMenuItem";
            this.quảnLýHànhHóaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýHànhHóaToolStripMenuItem.Text = "Hành Hóa";
            this.quảnLýHànhHóaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHànhHóaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvDanhSachLoai);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoai)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachLoai;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHànhHóaToolStripMenuItem;
    }
}

