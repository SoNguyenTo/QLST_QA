namespace QuanLySieuthi
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
            this.btNhapHang = new System.Windows.Forms.Button();
            this.btBanHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNhapHang
            // 
            this.btNhapHang.Location = new System.Drawing.Point(266, 285);
            this.btNhapHang.Name = "btNhapHang";
            this.btNhapHang.Size = new System.Drawing.Size(117, 48);
            this.btNhapHang.TabIndex = 1;
            this.btNhapHang.Text = "NHẬP HÀNG";
            this.btNhapHang.UseVisualStyleBackColor = true;
            this.btNhapHang.Click += new System.EventHandler(this.btNhapHang_Click);
            // 
            // btBanHang
            // 
            this.btBanHang.Location = new System.Drawing.Point(598, 285);
            this.btBanHang.Name = "btBanHang";
            this.btBanHang.Size = new System.Drawing.Size(117, 48);
            this.btBanHang.TabIndex = 2;
            this.btBanHang.Text = "BÁN HÀNG";
            this.btBanHang.UseVisualStyleBackColor = true;
            this.btBanHang.Click += new System.EventHandler(this.btBanHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ BÁN HÀNG SIÊU THỊ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySieuthi.Properties.Resources.mo_cua_hang_tap_hoa_o_nong_thon1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBanHang);
            this.Controls.Add(this.btNhapHang);
            this.Name = "FormMain";
            this.Text = "Trang Chủ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNhapHang;
        private System.Windows.Forms.Button btBanHang;
        private System.Windows.Forms.Label label1;
    }
}