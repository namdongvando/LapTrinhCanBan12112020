namespace WinForm1
{
    partial class FormPhuongTrinhBac1
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
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trinh Bậc 1";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(94, 115);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(100, 22);
            this.txtSoA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số b";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(245, 115);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(100, 22);
            this.txtSoB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(397, 115);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 5;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(263, 168);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "ax+b = 0";
            // 
            // FormPhuongTrinhBac1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 208);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label1);
            this.Name = "FormPhuongTrinhBac1";
            this.Text = "FormPhuongTrinhBac1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label5;
    }
}