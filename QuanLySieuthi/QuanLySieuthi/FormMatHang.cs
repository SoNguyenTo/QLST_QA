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
    public partial class FormMatHang : Form
    {
        private SqlConnection conn;
        private DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
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
        private void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TenMH";
            cl.HeaderText = "Tên mặt hàng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Gianhap";
            cl.HeaderText = "Giá nhập";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "GiaBanLe";
            cl.HeaderText = "Giá bán lẻ ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Thongtin";
            cl.HeaderText = "Thông tin";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "LoaiHang";
            cl.HeaderText = "Loại hàng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "SLTon";
            cl.HeaderText = "Số lượng tồn";
            dgv.Columns.Add(cl);
        }
        public void getdata()
        {
            dt.Clear();
            SqlCommand command = new SqlCommand("sp_THONGTINMATHANG", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@ten", txtTimKiemMh.Text));
            command.Parameters.Add(new SqlParameter("@loaihang", txtTimKiemMh.Text));
            da.SelectCommand = command;
            da.Fill(dt);
            dataGMatHang.DataSource = dt;
        }
        public void binding()
        {
            ID.DataBindings.Clear();
            ID.DataBindings.Add("Text", dataGMatHang.DataSource, "ma");
            txtMathangmh.DataBindings.Clear();
            txtMathangmh.DataBindings.Add("Text", dataGMatHang.DataSource, "TenMh");
            txtGiaNhapMh.DataBindings.Clear();
            txtGiaNhapMh.DataBindings.Add("Text", dataGMatHang.DataSource, "GiaNhap");
            txtGiaLeMh.DataBindings.Clear();
            txtGiaLeMh.DataBindings.Add("Text", dataGMatHang.DataSource, "GiaBanLe");
            txtLoaiHangMh.DataBindings.Clear();
            txtLoaiHangMh.DataBindings.Add("Text", dataGMatHang.DataSource, "LoaiHang");
            txtSLTonMh.DataBindings.Clear();
            txtSLTonMh.DataBindings.Add("Text", dataGMatHang.DataSource, "slTon");
            richTTtinMh.DataBindings.Clear();
            richTTtinMh.DataBindings.Add("Text", dataGMatHang.DataSource, "ThongTin");
        }
        public FormMatHang()
        {
            InitializeComponent();
        }

        private void FormMatHang_Load(object sender, EventArgs e)
        {
            connect();
            initGrid(dataGMatHang);
            getdata();
            binding();
        }

        private void txtGiaNhapMh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaLeMh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSLTonMh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            txtMathangmh.Clear();
            txtLoaiHangMh.Clear();
            txtGiaNhapMh.Clear();
            txtGiaLeMh.Clear();
            txtSLTonMh.Clear();
            txtLoaiHangMh.Clear();
            richTTtinMh.Clear();
            txtMathangmh.Enabled = true;
            txtGiaNhapMh.Enabled = true;
            txtGiaLeMh.Enabled = true;
            txtLoaiHangMh.Enabled = true;
            txtTimKiemMh.Enabled = false;
            txtSLTonMh.Enabled = false;
            richTTtinMh.Enabled = true;
            btnThemMH.Enabled = false;
            btnSuaMH.Enabled = false;
            btnCapNhatMh.Enabled = false;

        }

        private void btnLuuThemMh_Click(object sender, EventArgs e)
        {
            connect();
            if (txtGiaLeMh.Text == "" & txtGiaNhapMh.Text == "")
            {
                MessageBox.Show("Số lượng sản phẩm không phù hợp! Xem lại!", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }
            try
            {
                DialogResult dg = MessageBox.Show("Bạn muốn thêm mặt hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {

                    SqlCommand command = new SqlCommand("sp_THEMMATHANG", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ten", txtMathangmh.Text));
                    command.Parameters.Add(new SqlParameter("@gianhap", txtGiaNhapMh.Text));
                    command.Parameters.Add(new SqlParameter("@giabanle", txtGiaLeMh.Text));
                    command.Parameters.Add(new SqlParameter("@loaihang", txtLoaiHangMh.Text));
                    command.Parameters.Add(new SqlParameter("@thongtin", richTTtinMh.Text));

                    command.ExecuteNonQuery();
                    dt.Clear();
                    getdata();
                    binding();
                    MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    txtMathangmh.Enabled = false;
                    txtGiaNhapMh.Enabled = false;
                    txtGiaLeMh.Enabled = false;
                    txtLoaiHangMh.Enabled = false;
                    txtSLTonMh.Enabled = false;
                    txtTimKiemMh.Enabled = true;
                    richTTtinMh.Enabled = false;
                    btnThemMH.Enabled = true;
                    btnSuaMH.Enabled = true;
                    btnCapNhatMh.Enabled = true;

                }
                DialogResult dg1 = MessageBox.Show("Bạn muốn tiếp tục thêm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg1 == DialogResult.No)
                {
                    txtMathangmh.Enabled = false;
                    txtGiaNhapMh.Enabled = false;
                    txtGiaLeMh.Enabled = false;
                    txtLoaiHangMh.Enabled = false;
                    txtSLTonMh.Enabled = false;
                    txtTimKiemMh.Enabled = true;
                    richTTtinMh.Enabled = false;
                    btnThemMH.Enabled = true;
                    btnSuaMH.Enabled = true;
                    btnCapNhatMh.Enabled = true;
                   // disconect();
                }
                else
                {
                    txtMathangmh.Clear();
                    txtLoaiHangMh.Clear();
                    txtGiaNhapMh.Clear();
                    txtGiaLeMh.Clear();
                    txtSLTonMh.Clear();
                    txtLoaiHangMh.Clear();
                    richTTtinMh.Clear();
                    txtMathangmh.Enabled = true;
                    txtGiaNhapMh.Enabled = true;
                    txtGiaLeMh.Enabled = true;
                    txtLoaiHangMh.Enabled = true;
                    txtTimKiemMh.Enabled = false;
                    txtSLTonMh.Enabled = false;
                    richTTtinMh.Enabled = true;
                    btnThemMH.Enabled = false;
                    btnSuaMH.Enabled = false;
                    btnCapNhatMh.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Sản phẩm đã tồn tại, thử lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }
                
            


        private void btnHuyMH_Click(object sender, EventArgs e)
        {
            binding();
            txtMathangmh.Enabled = false;
            txtGiaNhapMh.Enabled = false;
            txtGiaLeMh.Enabled = false;
            txtLoaiHangMh.Enabled = false;
            txtTimKiemMh.Enabled = true;
            richTTtinMh.Enabled = false;
            txtSLTonMh.Enabled = false;
            richTTtinMh.Enabled = false;
            btnThemMH.Enabled = true;
            btnSuaMH.Enabled = true;
            btnCapNhatMh.Enabled = true;
            btnLuuThemMh.Enabled = true;
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            txtMathangmh.Enabled = true;
            txtGiaNhapMh.Enabled = true;
            txtGiaLeMh.Enabled = true;
            txtLoaiHangMh.Enabled = true;
            txtTimKiemMh.Enabled = false;
            richTTtinMh.Enabled = true;
            txtSLTonMh.Enabled = false;
            btnThemMH.Enabled = false;
            btnSuaMH.Enabled = false;
            btnCapNhatMh.Enabled = true;
            btnLuuThemMh.Enabled = false;
        }

        private void btnCapNhatMh_Click(object sender, EventArgs e)
        {
            connect();
            if (txtGiaLeMh.Text == "" & txtGiaNhapMh.Text == "")
            {
                MessageBox.Show("Số lượng sản phẩm không phù hợp! Xem lại!", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }
            try
            {
                DialogResult dg = MessageBox.Show("Bạn muốn sửa thông tin mặt hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {

                    SqlCommand command = new SqlCommand("sp_SUAMATHANG", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ma",int.Parse( ID.Text)));
                    command.Parameters.Add(new SqlParameter("@ten", txtMathangmh.Text));
                    command.Parameters.Add(new SqlParameter("@gianhap", txtGiaNhapMh.Text));
                    command.Parameters.Add(new SqlParameter("@giabanle", txtGiaLeMh.Text));
                    command.Parameters.Add(new SqlParameter("@loaihang", txtLoaiHangMh.Text));
                    command.Parameters.Add(new SqlParameter("@thongtin", richTTtinMh.Text));
                    command.ExecuteNonQuery();
                    dt.Clear();
                    getdata();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    txtMathangmh.Enabled = false;
                    txtGiaNhapMh.Enabled = false;
                    txtGiaLeMh.Enabled = false;
                    txtLoaiHangMh.Enabled = false;
                    txtTimKiemMh.Enabled = true;
                    richTTtinMh.Enabled = false;
                    txtSLTonMh.Enabled = false;
                    btnThemMH.Enabled = true;
                    btnSuaMH.Enabled = true;
                    btnCapNhatMh.Enabled = true;
                    btnLuuThemMh.Enabled = true;

                }
                DialogResult dg1 = MessageBox.Show("Bạn muốn tiếp tục thêm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg1 == DialogResult.No)
                {
                    txtMathangmh.Enabled = false;
                    txtGiaNhapMh.Enabled = false;
                    txtGiaLeMh.Enabled = false;
                    txtLoaiHangMh.Enabled = false;
                    txtTimKiemMh.Enabled = true;
                    richTTtinMh.Enabled = false;
                    txtSLTonMh.Enabled = false;
                    btnThemMH.Enabled = true;
                    btnSuaMH.Enabled = true;
                    btnCapNhatMh.Enabled = true;
                    btnLuuThemMh.Enabled = true;
                    disconect();
                }
            }
            catch
            {
                MessageBox.Show("Sản phẩm đã tồn tại, thử lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void txtTimKiemMh_TextChanged(object sender, EventArgs e)
        {
            connect();
            getdata();
        }
    }
}
