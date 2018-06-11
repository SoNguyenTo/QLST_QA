namespace QuanLySieuthi
{
    partial class FormNhapHang
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
            this.cbbNguoiNhap = new System.Windows.Forms.ComboBox();
            this.dtpNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtSophieunhap = new System.Windows.Forms.TextBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grPhieuNhap = new System.Windows.Forms.GroupBox();
            this.txtNhaCungCap = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.grChiTietPhieuHang = new System.Windows.Forms.GroupBox();
            this.MaMH = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnHuyHang = new System.Windows.Forms.Button();
            this.btnLuuHang = new System.Windows.Forms.Button();
            this.btnSuaHang = new System.Windows.Forms.Button();
            this.dgvChiTietHang = new System.Windows.Forms.DataGridView();
            this.btnXoaHang = new System.Windows.Forms.Button();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbbMatHang = new System.Windows.Forms.ComboBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grPhieuNhap.SuspendLayout();
            this.grChiTietPhieuHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHang)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbNguoiNhap
            // 
            this.cbbNguoiNhap.FormattingEnabled = true;
            this.cbbNguoiNhap.Location = new System.Drawing.Point(89, 66);
            this.cbbNguoiNhap.Name = "cbbNguoiNhap";
            this.cbbNguoiNhap.Size = new System.Drawing.Size(244, 21);
            this.cbbNguoiNhap.TabIndex = 6;
            // 
            // dtpNgaynhap
            // 
            this.dtpNgaynhap.Enabled = false;
            this.dtpNgaynhap.Location = new System.Drawing.Point(89, 42);
            this.dtpNgaynhap.Name = "dtpNgaynhap";
            this.dtpNgaynhap.Size = new System.Drawing.Size(244, 20);
            this.dtpNgaynhap.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Người nhập ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phiếu nhập hàng";
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(191, 185);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 23);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(284, 185);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(72, 23);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtSophieunhap
            // 
            this.txtSophieunhap.Enabled = false;
            this.txtSophieunhap.Location = new System.Drawing.Point(89, 16);
            this.txtSophieunhap.Name = "txtSophieunhap";
            this.txtSophieunhap.Size = new System.Drawing.Size(244, 20);
            this.txtSophieunhap.TabIndex = 4;
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(6, 15);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(596, 100);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            this.dgvPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellContentClick);
            this.dgvPhieuNhap.DoubleClick += new System.EventHandler(this.dgvPhieuNhap_DoubleClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(100, 185);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 23);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhieuNhap);
            this.groupBox2.Location = new System.Drawing.Point(364, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 121);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // grPhieuNhap
            // 
            this.grPhieuNhap.Controls.Add(this.txtNhaCungCap);
            this.grPhieuNhap.Controls.Add(this.cbbNguoiNhap);
            this.grPhieuNhap.Controls.Add(this.dtpNgaynhap);
            this.grPhieuNhap.Controls.Add(this.txtSophieunhap);
            this.grPhieuNhap.Controls.Add(this.label1);
            this.grPhieuNhap.Controls.Add(this.label4);
            this.grPhieuNhap.Controls.Add(this.label2);
            this.grPhieuNhap.Controls.Add(this.label3);
            this.grPhieuNhap.Enabled = false;
            this.grPhieuNhap.Location = new System.Drawing.Point(12, 57);
            this.grPhieuNhap.Name = "grPhieuNhap";
            this.grPhieuNhap.Size = new System.Drawing.Size(346, 121);
            this.grPhieuNhap.TabIndex = 15;
            this.grPhieuNhap.TabStop = false;
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.Location = new System.Drawing.Point(89, 93);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(244, 20);
            this.txtNhaCungCap.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 185);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Phiếu mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grChiTietPhieuHang
            // 
            this.grChiTietPhieuHang.Controls.Add(this.MaMH);
            this.grChiTietPhieuHang.Controls.Add(this.txtSoLuong);
            this.grChiTietPhieuHang.Controls.Add(this.btnHuyHang);
            this.grChiTietPhieuHang.Controls.Add(this.btnLuuHang);
            this.grChiTietPhieuHang.Controls.Add(this.btnSuaHang);
            this.grChiTietPhieuHang.Controls.Add(this.dgvChiTietHang);
            this.grChiTietPhieuHang.Controls.Add(this.btnXoaHang);
            this.grChiTietPhieuHang.Controls.Add(this.btnThemHang);
            this.grChiTietPhieuHang.Controls.Add(this.label22);
            this.grChiTietPhieuHang.Controls.Add(this.label23);
            this.grChiTietPhieuHang.Controls.Add(this.cbbMatHang);
            this.grChiTietPhieuHang.Enabled = false;
            this.grChiTietPhieuHang.Location = new System.Drawing.Point(12, 214);
            this.grChiTietPhieuHang.Name = "grChiTietPhieuHang";
            this.grChiTietPhieuHang.Size = new System.Drawing.Size(960, 244);
            this.grChiTietPhieuHang.TabIndex = 23;
            this.grChiTietPhieuHang.TabStop = false;
            this.grChiTietPhieuHang.Text = "Chi tiết phiếu hàng";
            // 
            // MaMH
            // 
            this.MaMH.AutoSize = true;
            this.MaMH.ForeColor = System.Drawing.SystemColors.Control;
            this.MaMH.Location = new System.Drawing.Point(6, 63);
            this.MaMH.Name = "MaMH";
            this.MaMH.Size = new System.Drawing.Size(0, 13);
            this.MaMH.TabIndex = 56;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(324, 30);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(96, 20);
            this.txtSoLuong.TabIndex = 41;
            // 
            // btnHuyHang
            // 
            this.btnHuyHang.Enabled = false;
            this.btnHuyHang.Location = new System.Drawing.Point(791, 52);
            this.btnHuyHang.Name = "btnHuyHang";
            this.btnHuyHang.Size = new System.Drawing.Size(67, 23);
            this.btnHuyHang.TabIndex = 53;
            this.btnHuyHang.Text = "Hủy";
            this.btnHuyHang.UseVisualStyleBackColor = true;
            this.btnHuyHang.Click += new System.EventHandler(this.btnHuyHang_Click);
            // 
            // btnLuuHang
            // 
            this.btnLuuHang.Enabled = false;
            this.btnLuuHang.Location = new System.Drawing.Point(791, 23);
            this.btnLuuHang.Name = "btnLuuHang";
            this.btnLuuHang.Size = new System.Drawing.Size(67, 23);
            this.btnLuuHang.TabIndex = 52;
            this.btnLuuHang.Text = "Lưu";
            this.btnLuuHang.UseVisualStyleBackColor = true;
            this.btnLuuHang.Click += new System.EventHandler(this.btnLuuHang_Click);
            // 
            // btnSuaHang
            // 
            this.btnSuaHang.Location = new System.Drawing.Point(696, 53);
            this.btnSuaHang.Name = "btnSuaHang";
            this.btnSuaHang.Size = new System.Drawing.Size(67, 23);
            this.btnSuaHang.TabIndex = 49;
            this.btnSuaHang.Text = "Sửa SP";
            this.btnSuaHang.UseVisualStyleBackColor = true;
            this.btnSuaHang.Click += new System.EventHandler(this.btnSuaHang_Click);
            // 
            // dgvChiTietHang
            // 
            this.dgvChiTietHang.AllowUserToAddRows = false;
            this.dgvChiTietHang.AllowUserToDeleteRows = false;
            this.dgvChiTietHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChiTietHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHang.Location = new System.Drawing.Point(5, 92);
            this.dgvChiTietHang.Name = "dgvChiTietHang";
            this.dgvChiTietHang.ReadOnly = true;
            this.dgvChiTietHang.Size = new System.Drawing.Size(952, 143);
            this.dgvChiTietHang.TabIndex = 46;
            this.dgvChiTietHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHang_CellClick);
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.Location = new System.Drawing.Point(887, 23);
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.Size = new System.Drawing.Size(67, 23);
            this.btnXoaHang.TabIndex = 45;
            this.btnXoaHang.Text = "Xóa SP";
            this.btnXoaHang.UseVisualStyleBackColor = true;
            this.btnXoaHang.Click += new System.EventHandler(this.btnXoaHang_Click);
            // 
            // btnThemHang
            // 
            this.btnThemHang.Location = new System.Drawing.Point(696, 23);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(67, 23);
            this.btnThemHang.TabIndex = 44;
            this.btnThemHang.Text = "Thêm SP";
            this.btnThemHang.UseVisualStyleBackColor = true;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(2, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "Tên SP";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(269, 33);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 42;
            this.label23.Text = "Số lượng";
            // 
            // cbbMatHang
            // 
            this.cbbMatHang.Enabled = false;
            this.cbbMatHang.FormattingEnabled = true;
            this.cbbMatHang.Location = new System.Drawing.Point(79, 30);
            this.cbbMatHang.Name = "cbbMatHang";
            this.cbbMatHang.Size = new System.Drawing.Size(159, 21);
            this.cbbMatHang.TabIndex = 40;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Location = new System.Drawing.Point(370, 180);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 33);
            this.btnThanhToan.TabIndex = 24;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.grChiTietPhieuHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grPhieuNhap);
            this.Controls.Add(this.btnThem);
            this.Name = "FormNhapHang";
            this.Text = "Thông tin nhập hàng";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grPhieuNhap.ResumeLayout(false);
            this.grPhieuNhap.PerformLayout();
            this.grChiTietPhieuHang.ResumeLayout(false);
            this.grChiTietPhieuHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbNguoiNhap;
        private System.Windows.Forms.DateTimePicker dtpNgaynhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtSophieunhap;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grPhieuNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grChiTietPhieuHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnHuyHang;
        private System.Windows.Forms.Button btnLuuHang;
        private System.Windows.Forms.Button btnSuaHang;
        private System.Windows.Forms.DataGridView dgvChiTietHang;
        private System.Windows.Forms.Button btnXoaHang;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbbMatHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private System.Windows.Forms.Label MaMH;
    }
}