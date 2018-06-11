using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuthi
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btNhapHang_Click(object sender, EventArgs e)
        {
            FormNhapHang frnh = new FormNhapHang();
            frnh.Show();
        }

        private void btBanHang_Click(object sender, EventArgs e)
        {
            FormBanHang frbh = new FormBanHang();
            frbh.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
