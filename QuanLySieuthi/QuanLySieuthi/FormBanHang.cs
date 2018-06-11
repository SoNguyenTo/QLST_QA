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
    public partial class FormBanHang : Form
    {
        public FormBanHang()
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
            catch(Exception e)
            {
                MessageBox.Show("LỖI");
            }
        }
        public void disconnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }

        public void getdataKhachHang()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select * from KHACHHANG";
            da.SelectCommand = command;
            da.Fill(dt);
            dgvKhachHang.DataSource = dt;
        }
        public void getdataMatHang()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            DataTable dt1 = new DataTable();

            cm.Connection = con;

            cm.CommandText = "select * from MATHANG";
            da.SelectCommand = cm;
            da.Fill(dt1);
            cbbMatHang.DataSource = dt1;
            cbbMatHang.DisplayMember = "TenMH";
            cbbMatHang.ValueMember = "Ma";
        }

        public void getdataNVBH()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            DataTable data = new DataTable();

            cm.Connection = con;

            cm.CommandText = "select * from NHANVIEN";
            da.SelectCommand = cm;
            da.Fill(data);
            cbbNVBH.DataSource = data;
            cbbNVBH.DisplayMember = "Hoten";
            cbbNVBH.ValueMember = "Ma";
        }

        public void getdataChiTietBanHang()
        {
            SqlCommand command = new SqlCommand();
            DataTable data = new DataTable();
            command.Connection = conn;
            command.CommandText = "select Hoten, mh.TenMH, ctb.SoLuongBan, ctb.DonGia from CHITIETBANHANG ctb, MATHANG mh, NHANVIEN nv on ctb.MaMH = mh.Ma where ctb.Ma = @Ma and ctb.Ma = nv.Ma";
            command.Parameters.Add(new SqlParameter("@ma", tbMaBH.Text));
            da.SelectCommand = command;
            da.Fill(data);
            dgvChiTietBanHang.DataSource = data;
        }
        private void btLuuKH_Click(object sender, EventArgs e)
        {
            if(btThemKH.Enabled == true && btSuaKH.Enabled == false)
            {
                connect();
                try
                {
                    SqlCommand command = new SqlCommand("sp_THEMKHACHHANG", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@hoten", tbTenKhach.Text));
                    command.Parameters.Add(new SqlParameter("@dienthoai", tbTenKhach.Text));
                    command.Parameters.Add(new SqlParameter("@diachi", tbTenKhach.Text));
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
            if(btThemKH.Enabled == false && btSuaKH.Enabled == true)
            {
                connect();
                try
                {
                    SqlCommand command = new SqlCommand("sp_SUAKHACHHANG", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ma", tbMaKhachHang.Text));
                    command.Parameters.Add(new SqlParameter("@hoten", tbTenKhach.Text));
                    command.Parameters.Add(new SqlParameter("@dienthoai", tbTenKhach.Text));
                    command.Parameters.Add(new SqlParameter("@diachi", tbTenKhach.Text));
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
            getdataKhachHang();
            disconnect();
            gbKhachHang.Enabled = false;
            btLuuKH.Enabled = false;
            btHuyKH.Enabled = false;
            btThemKH.Enabled = true;
            btSuaKH.Enabled = true;
            btThanhToanKH.Enabled = true;
        }

        private void btnLuuHang_Click(object sender, EventArgs e)
        {
            if (btnThemHang.Enabled == true && btnSuaHang.Enabled == false)
            {

                connect();
                try
                {
                    SqlCommand command = new SqlCommand("sp_THEMCHITIETBAN", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@mamh", cbbMatHang.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@mabh", tbMaBH.Text));
                    command.Parameters.Add(new SqlParameter("@soluong", int.Parse(txtSoLuong.Text)));
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
                    SqlCommand command = new SqlCommand("sp_SUACHITIETBAN", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@mabh", tbMaBH.Text));
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
            getdataChiTietBanHang();
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
        public void bindingKhachHang()
        {
            tbMaKhachHang.DataBindings.Clear();
            tbMaKhachHang.DataBindings.Add("Text", dgvKhachHang.DataSource, "Ma");
            tbTenKhach.DataBindings.Clear();
            tbTenKhach.DataBindings.Add("Text", dgvKhachHang.DataSource, "Hoten");
            tbSodt.DataBindings.Clear();
            tbSodt.DataBindings.Add("Text", dgvKhachHang.DataSource, "DienThoai");
            tbDiaChiKhach.DataBindings.Clear();
            tbDiaChiKhach.DataBindings.Add("Text", dgvKhachHang.DataSource, "DiaChi");
        }
        public void bindingChiTietBanHang()
        {
            tbMaBH.DataBindings.Clear();
            tbMaBH.DataBindings.Add("Text", dgvChiTietBanHang.DataSource, "Ma");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvChiTietBanHang.DataSource, "SoLuongBan");
            cbbMatHang.DataBindings.Clear();
            cbbMatHang.DataBindings.Add("Text", dgvChiTietBanHang.DataSource, "TenMH");
            cbbNVBH.DataBindings.Clear();
            cbbNVBH.DataBindings.Add("Text", dgvChiTietBanHang.DataSource, "Hoten");
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            connect();
            getdataKhachHang();
            getdataNVBH();
            bindingKhachHang();
            disconnect();
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {

            connect();
            try
            {
                SqlCommand command = new SqlCommand("sp_XOACHITIETBAN", conn);
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
            getdataChiTietBanHang();
            disconnect();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dt1.Clear();
            connect();
            getdataMatHang();
            getdataChiTietBanHang();
            bindingChiTietBanHang();
            disconnect();
        }
    
    }
}
