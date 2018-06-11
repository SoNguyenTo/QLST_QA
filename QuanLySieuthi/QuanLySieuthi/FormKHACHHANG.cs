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
    public partial class FormKhachHang : Form
    {
       
        public FormKhachHang()
        {
            InitializeComponent();
        }
        public bool isChecked = false;
        public bool isClick;
        private SqlConnection conn;
        public DataTable dt = new DataTable("tblKHACHHANG");
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
        public void getdata()
        {
            dt.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TIMKIEMKHACHHANG";
            command.Parameters.Add(new SqlParameter("@hoten", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@diachi", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@dienthoai", txtTimKiem.Text));
            da.SelectCommand = command;
            da.Fill(dt);
            dgvkhachhang.DataSource = dt;

        }

        private void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "hoten";
            cl.HeaderText = "Họ Tên";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "diachi";
            cl.HeaderText = "Địa Chỉ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "dienthoai";
            cl.HeaderText = "Điện Thoại";
            dgv.Columns.Add(cl);

        }

        public void dataBinding()
        {
            lblma.DataBindings.Clear();
            lblma.DataBindings.Add("Text", dgvkhachhang.DataSource, "ma");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", dgvkhachhang.DataSource, "hoten");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvkhachhang.DataSource, "diachi");
            txtDienthoai.DataBindings.Clear();
            txtDienthoai.DataBindings.Add("Text", dgvkhachhang.DataSource, "dienthoai");
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuuthemmoi.Enabled = true;
            btnHuy.Enabled = true;
            btnCapnhat.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvkhachhang.Enabled = false;
            ClearData();
            EnableData();
        }

       

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (isChecked == false)
            {
                MessageBox.Show("Chọn 1 thằng đi đã");
                return;
            }
            if (isEmpty()) return;
            connect();
            try
            {
                SqlCommand command = new SqlCommand("sp_SUAKHACHHANG", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ma", int.Parse(lblma.Text)));
                command.Parameters.Add(new SqlParameter("@hoten", txtHoten.Text));
                command.Parameters.Add(new SqlParameter("@diachi", txtDiaChi.Text));
                command.Parameters.Add(new SqlParameter("@dienthoai", txtDienthoai.Text));
               

                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt.Clear();
            }
            getdata();
            disconect();
            btnLuuthemmoi.Enabled = false;
            btnHuy.Enabled = false;         
            btnCapnhat.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            DisableData();
           
            dgvkhachhang.Enabled = true;
        }

        private bool isEmpty()
        {
            if (txtHoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            
            else if (txtDienthoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điện thoại", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void btnLuuthemmoi_Click(object sender, EventArgs e)
        {
            if (isEmpty())
                return;
            connect();
            try
            {
                SqlCommand command = new SqlCommand("sp_THEMKHACHHANG", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@hoten", txtHoten.Text));
                command.Parameters.Add(new SqlParameter("@diachi", txtDiaChi.Text));
                command.Parameters.Add(new SqlParameter("@dienthoai", txtDienthoai.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
                btnHuy.Enabled = false;
                btnCapnhat.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getdata();
            disconect();
            DisableData();
            dgvkhachhang.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuuthemmoi.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
        }

        void ClearData()
        {

            txtHoten.Clear();

            txtDiaChi.Clear();
            txtDienthoai.Clear();
        }

        void DisableData()
        {
            txtHoten.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienthoai.Enabled = false;
        }

        void EnableData()
        {
            txtHoten.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienthoai.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            connect();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuuthemmoi.Enabled = false;
            btnCapnhat.Enabled = false;
            dgvkhachhang.Enabled = true;
            getdata();
            disconect();
            DisableData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isChecked)
            {
                EnableData();
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnHuy.Enabled = true;
                btnCapnhat.Enabled = true;
                dgvkhachhang.Enabled = false;

            }
            else
            {
                MessageBox.Show("Chọn 1 thằng đi đã");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            connect();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TIMKIEMKHACHHANG";
            command.Parameters.Add(new SqlParameter("@hoten", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@diachi", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@dienthoai", txtTimKiem.Text));
            da.SelectCommand = command;
            da.Fill(dt);
            dgvkhachhang.DataSource = dt;
            disconect();
        }

        private void FormKHACHHANG_Load(object sender, EventArgs e)
        {
            connect();
            initGrid(dgvkhachhang);
            getdata();
            dataBinding();    
            disconect();
        }

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isChecked = true;
            dataBinding();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                SqlCommand command = new SqlCommand("sp_XOAKHACHHANG", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ma", int.Parse(lblma.Text)));
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getdata();
            disconect();
        }
    }
}
