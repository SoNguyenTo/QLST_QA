
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuthi
{
    public partial class FormNhapHang : Form
    {
        public FormNhapHang()
        {
            InitializeComponent();
        }


        private SqlConnection conn;
        private DataTable dt = new DataTable();
        private DataTable dt1 = new DataTable();

        private SqlDataAdapter da = new SqlDataAdapter();
        public void connect()
        {
            String conStr = globalParameter.str;
            try
            {

                conn = new SqlConnection(conStr);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("LỖI");
            }
        }
        public void disconect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }

        public void getdataPhieuNhap()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select nk.Ma , nk.NgayNhap,nv.Hoten , nk.NhaCungCap , nk.TongTien  from NHAPKHO nk join NHANVIEN nv on nk.MaNV=nv.Ma";
            da.SelectCommand = command;
            da.Fill(dt);
            dgvPhieuNhap.DataSource = dt;
        }
        public void getdataChiTietPhieuNhap()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select ctn.Ma,mh.TenMH , ctn.SoLuongNhap , ctn.DonGia from CHITIETNHAP ctn join NHAPKHO nk on ctn.MaNhap=nk.Ma join MATHANG mh on ctn.MaMH= mh.Ma where nk.Ma=@Ma";
            command.Parameters.Add(new SqlParameter("@ma",txtSophieunhap.Text));
            da.SelectCommand = command;
            da.Fill(dt1);
            dgvChiTietHang.DataSource = dt1;
        }
        public void getdataMatHang()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            DataTable data = new DataTable();

            cm.Connection = con;

            cm.CommandText = "select * from MATHANG";
            da.SelectCommand = cm;
            da.Fill(data);
            cbbMatHang.DataSource = data;
            cbbMatHang.DisplayMember = "TenMH";
            cbbMatHang.ValueMember = "Ma";
        }

        public void getdataNguoiNhap()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            DataTable data = new DataTable();

            cm.Connection = con;

            cm.CommandText = "select * from NHANVIEN";
            da.SelectCommand = cm;
            da.Fill(data);
            cbbNguoiNhap.DataSource = data;
            cbbNguoiNhap.DisplayMember = "HoTen";
            cbbNguoiNhap.ValueMember = "Ma";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            grPhieuNhap.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnThanhToan.Enabled = false;
            txtNhaCungCap.Clear();
 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grPhieuNhap.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnThanhToan.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            grPhieuNhap.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnThanhToan.Enabled = true;
        }

        private void dgvPhieuNhap_DoubleClick(object sender, EventArgs e)
        {
            dt1.Clear();
            connect();
            getdataMatHang();
            getdataChiTietPhieuNhap();
            bindingChiTietMatHang();
            grChiTietPhieuHang.Enabled = true;
            disconect();
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            cbbMatHang.Enabled = true;
            txtSoLuong.Enabled = true;
           
            btnLuuHang.Enabled = true;
            btnHuyHang.Enabled = true;
            btnSuaHang.Enabled = false;
            btnXoaHang.Enabled = false;
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            txtSoLuong.Enabled = true;
            btnLuuHang.Enabled = true;
            btnHuyHang.Enabled = true;
            btnThemHang.Enabled = false;
            btnXoaHang.Enabled = false;
            cbbMatHang.Enabled = false;
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true && btnSua.Enabled == false)
            {

                connect();
                try
                {
                    SqlCommand command = new SqlCommand("sp_THEMPHIEUNHAP", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@manv", cbbNguoiNhap.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@nhacc", txtNhaCungCap.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (btnThem.Enabled == false && btnSua.Enabled == true)
            {
                connect();
                try
                {
                    SqlCommand command = new SqlCommand("sp_SUAPHIEUNHAP", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ma", txtSophieunhap.Text));
                    command.Parameters.Add(new SqlParameter("@nhacc", txtNhaCungCap.Text));
                    command.Parameters.Add(new SqlParameter("@manv", cbbNguoiNhap.SelectedValue));
                  
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            getdataPhieuNhap();
            disconect();
            grPhieuNhap.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnThanhToan.Enabled = true;
        }
        private void btnLuuHang_Click(object sender, EventArgs e)
        {

            if (btnThemHang.Enabled == true && btnSuaHang.Enabled == false)
            {

                connect();
                try
                {
                    SqlCommand command = new SqlCommand("sp_THEMCHITIETNHAP", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@mamh", cbbMatHang.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@manhap", txtSophieunhap.Text));
                    command.Parameters.Add(new SqlParameter("@soluong",int.Parse(txtSoLuong.Text)));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt1.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (btnThemHang.Enabled == false && btnSuaHang.Enabled == true)
            {
                connect();
                try
                {
                    SqlCommand command = new SqlCommand("sp_SUACHITIETNHAP", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ma", txtSophieunhap.Text));
                    command.Parameters.Add(new SqlParameter("@soluong", int.Parse(txtSoLuong.Text)));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt1.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            getdataChiTietPhieuNhap();
            cbbMatHang.Enabled = false;
            
            txtSoLuong.Enabled = false;
            btnThemHang.Enabled = true;
            btnSuaHang.Enabled = true;
            btnXoaHang.Enabled = true;
            btnLuuHang.Enabled = false;
            btnHuyHang.Enabled = false;

        }

        private void btnHuyHang_Click(object sender, EventArgs e)

        {
            cbbMatHang.Enabled = false;
            
            txtSoLuong.Enabled = false;
            btnThemHang.Enabled = true;
            btnSuaHang.Enabled = true;
            btnXoaHang.Enabled = true;
            btnLuuHang.Enabled = false;
            btnHuyHang.Enabled = false;
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            connect();
            getdataPhieuNhap();
            getdataNguoiNhap();
            bindingPhieuHang();
            
            disconect();
        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void bindingPhieuHang()
        {
            txtSophieunhap.DataBindings.Clear();
            txtSophieunhap.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "Ma");
            txtNhaCungCap.DataBindings.Clear();
            txtNhaCungCap.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "NhaCungCap");
            dtpNgaynhap.DataBindings.Clear();
            dtpNgaynhap.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "NgayNhap");
            cbbNguoiNhap.DataBindings.Clear();
            cbbNguoiNhap.DataBindings.Add("Text", dgvPhieuNhap.DataSource, "HoTen");
        }
        public void bindingChiTietMatHang()
        {
            MaMH.DataBindings.Clear();
            MaMH.DataBindings.Add("Text", dgvChiTietHang.DataSource, "Ma");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvChiTietHang.DataSource, "SoLuongNhap");

        }
        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                SqlCommand command = new SqlCommand("sp_XOACHITIETNHAP", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("ma", MaMH.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dt1.Clear();
            getdataChiTietPhieuNhap();
            disconect();
        }

        private void dgvChiTietHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingChiTietMatHang();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dt1.Clear();
            connect();
            getdataMatHang();
            getdataChiTietPhieuNhap();
            bindingChiTietMatHang();
            disconect();
        }
    }  
}
