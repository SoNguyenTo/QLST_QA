namespace QuanLySieuthi
{
    partial class FormMatHang
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
            this.dataGMatHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.Label();
            this.txtSLTonMh = new System.Windows.Forms.TextBox();
            this.txtGiaLeMh = new System.Windows.Forms.TextBox();
            this.txtLoaiHangMh = new System.Windows.Forms.TextBox();
            this.txtGiaNhapMh = new System.Windows.Forms.TextBox();
            this.txtMathangmh = new System.Windows.Forms.TextBox();
            this.richTTtinMh = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimKiemMh = new System.Windows.Forms.TextBox();
            this.btnHuyMH = new System.Windows.Forms.Button();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnCapNhatMh = new System.Windows.Forms.Button();
            this.btnLuuThemMh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGMatHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "MẶT HÀNG";
            // 
            // dataGMatHang
            // 
            this.dataGMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGMatHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGMatHang.Location = new System.Drawing.Point(40, 263);
            this.dataGMatHang.Name = "dataGMatHang";
            this.dataGMatHang.Size = new System.Drawing.Size(890, 187);
            this.dataGMatHang.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.txtSLTonMh);
            this.groupBox1.Controls.Add(this.txtGiaLeMh);
            this.groupBox1.Controls.Add(this.txtLoaiHangMh);
            this.groupBox1.Controls.Add(this.txtGiaNhapMh);
            this.groupBox1.Controls.Add(this.txtMathangmh);
            this.groupBox1.Controls.Add(this.richTTtinMh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(40, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 178);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.ForeColor = System.Drawing.SystemColors.Control;
            this.ID.Location = new System.Drawing.Point(310, 18);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 13);
            this.ID.TabIndex = 21;
            // 
            // txtSLTonMh
            // 
            this.txtSLTonMh.Location = new System.Drawing.Point(359, 146);
            this.txtSLTonMh.Name = "txtSLTonMh";
            this.txtSLTonMh.Size = new System.Drawing.Size(152, 20);
            this.txtSLTonMh.TabIndex = 20;
            this.txtSLTonMh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLTonMh_KeyPress);
            // 
            // txtGiaLeMh
            // 
            this.txtGiaLeMh.Location = new System.Drawing.Point(359, 79);
            this.txtGiaLeMh.Name = "txtGiaLeMh";
            this.txtGiaLeMh.Size = new System.Drawing.Size(152, 20);
            this.txtGiaLeMh.TabIndex = 19;
            this.txtGiaLeMh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaLeMh_KeyPress);
            // 
            // txtLoaiHangMh
            // 
            this.txtLoaiHangMh.Location = new System.Drawing.Point(87, 146);
            this.txtLoaiHangMh.Name = "txtLoaiHangMh";
            this.txtLoaiHangMh.Size = new System.Drawing.Size(177, 20);
            this.txtLoaiHangMh.TabIndex = 18;
            // 
            // txtGiaNhapMh
            // 
            this.txtGiaNhapMh.Location = new System.Drawing.Point(87, 79);
            this.txtGiaNhapMh.Name = "txtGiaNhapMh";
            this.txtGiaNhapMh.Size = new System.Drawing.Size(177, 20);
            this.txtGiaNhapMh.TabIndex = 17;
            this.txtGiaNhapMh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhapMh_KeyPress);
            // 
            // txtMathangmh
            // 
            this.txtMathangmh.Location = new System.Drawing.Point(87, 12);
            this.txtMathangmh.Name = "txtMathangmh";
            this.txtMathangmh.Size = new System.Drawing.Size(177, 20);
            this.txtMathangmh.TabIndex = 16;
            // 
            // richTTtinMh
            // 
            this.richTTtinMh.Location = new System.Drawing.Point(599, 79);
            this.richTTtinMh.Name = "richTTtinMh";
            this.richTTtinMh.Size = new System.Drawing.Size(290, 82);
            this.richTTtinMh.TabIndex = 15;
            this.richTTtinMh.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số lượng tồn :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thông tin :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loại hàng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giá bán lẻ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Giá nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên mặt hàng :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTimKiemMh);
            this.groupBox2.Controls.Add(this.btnHuyMH);
            this.groupBox2.Controls.Add(this.btnThemMH);
            this.groupBox2.Controls.Add(this.btnSuaMH);
            this.groupBox2.Controls.Add(this.btnCapNhatMh);
            this.groupBox2.Controls.Add(this.btnLuuThemMh);
            this.groupBox2.Location = new System.Drawing.Point(262, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 60);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tìm kiếm :";
            // 
            // txtTimKiemMh
            // 
            this.txtTimKiemMh.Location = new System.Drawing.Point(88, 7);
            this.txtTimKiemMh.Name = "txtTimKiemMh";
            this.txtTimKiemMh.Size = new System.Drawing.Size(222, 20);
            this.txtTimKiemMh.TabIndex = 24;
            this.txtTimKiemMh.TextChanged += new System.EventHandler(this.txtTimKiemMh_TextChanged);
            // 
            // btnHuyMH
            // 
            this.btnHuyMH.Location = new System.Drawing.Point(505, 34);
            this.btnHuyMH.Name = "btnHuyMH";
            this.btnHuyMH.Size = new System.Drawing.Size(156, 23);
            this.btnHuyMH.TabIndex = 23;
            this.btnHuyMH.Text = "Hủy";
            this.btnHuyMH.UseVisualStyleBackColor = true;
            this.btnHuyMH.Click += new System.EventHandler(this.btnHuyMH_Click);
            // 
            // btnThemMH
            // 
            this.btnThemMH.Location = new System.Drawing.Point(343, 7);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(100, 21);
            this.btnThemMH.TabIndex = 21;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Location = new System.Drawing.Point(449, 7);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(96, 23);
            this.btnSuaMH.TabIndex = 22;
            this.btnSuaMH.Text = "Sửa";
            this.btnSuaMH.UseVisualStyleBackColor = true;
            this.btnSuaMH.Click += new System.EventHandler(this.btnSuaMH_Click);
            // 
            // btnCapNhatMh
            // 
            this.btnCapNhatMh.Location = new System.Drawing.Point(551, 6);
            this.btnCapNhatMh.Name = "btnCapNhatMh";
            this.btnCapNhatMh.Size = new System.Drawing.Size(110, 23);
            this.btnCapNhatMh.TabIndex = 20;
            this.btnCapNhatMh.Text = "Cập nhật";
            this.btnCapNhatMh.UseVisualStyleBackColor = true;
            this.btnCapNhatMh.Click += new System.EventHandler(this.btnCapNhatMh_Click);
            // 
            // btnLuuThemMh
            // 
            this.btnLuuThemMh.Location = new System.Drawing.Point(343, 34);
            this.btnLuuThemMh.Name = "btnLuuThemMh";
            this.btnLuuThemMh.Size = new System.Drawing.Size(156, 23);
            this.btnLuuThemMh.TabIndex = 19;
            this.btnLuuThemMh.Text = "Lưu Thêm Mới";
            this.btnLuuThemMh.UseVisualStyleBackColor = true;
            this.btnLuuThemMh.Click += new System.EventHandler(this.btnLuuThemMh_Click);
            // 
            // FormMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGMatHang);
            this.Controls.Add(this.label1);
            this.Name = "FormMatHang";
            this.Text = "FormMatHang";
            this.Load += new System.EventHandler(this.FormMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGMatHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGMatHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSLTonMh;
        private System.Windows.Forms.TextBox txtGiaLeMh;
        private System.Windows.Forms.TextBox txtLoaiHangMh;
        private System.Windows.Forms.TextBox txtGiaNhapMh;
        private System.Windows.Forms.TextBox txtMathangmh;
        private System.Windows.Forms.RichTextBox richTTtinMh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimKiemMh;
        private System.Windows.Forms.Button btnHuyMH;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnCapNhatMh;
        private System.Windows.Forms.Button btnLuuThemMh;
        private System.Windows.Forms.Label ID;
    }
}