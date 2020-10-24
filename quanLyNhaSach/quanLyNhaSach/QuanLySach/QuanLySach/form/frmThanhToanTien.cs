using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.form
{
    public partial class frmThanhToanTien : Form
    {
        double tongtien = 0;
        public frmThanhToanTien()
        {
            InitializeComponent();
        }

        


        public delegate void GETDATATINHTIEN(string data);
        public GETDATATINHTIEN tinhtien;

        private void btnenter_Click(object sender, EventArgs e)
        {
            
            tinhtien(txtDisplayTongTien.Text.Trim());
            this.Hide();
        }

        private void btn500K_Click(object sender, EventArgs e)
        {
            tongtien += 500000;
            txtDisplayTongTien.Text = tongtien.ToString();
        }

        private void btn200k_Click(object sender, EventArgs e)
        {
            tongtien += 200000;
            txtDisplayTongTien.Text = tongtien.ToString();
        }

        private void btn100k_Click(object sender, EventArgs e)
        {
            tongtien += 100000;
            txtDisplayTongTien.Text = tongtien.ToString();
        }

        private void btn50k_Click(object sender, EventArgs e)
        {
            tongtien += 50000;
            txtDisplayTongTien.Text = tongtien.ToString();
        }

        private void btn20k_Click(object sender, EventArgs e)
        {
            tongtien += 20000;
            txtDisplayTongTien.Text = tongtien.ToString();
        }

        private void btn10k_Click(object sender, EventArgs e)
        {
            tongtien += 10000;
            txtDisplayTongTien.Text = tongtien.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            tongtien = 0;
            txtDisplayTongTien.Text = tongtien.ToString();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplayTongTien.Text = "";
                tinhtien(txtDisplayTongTien.Text.Trim());
                this.Hide();
            }
            catch(Exception ed)
            {
                MessageBox.Show("Đã Hủy Phương Thức Thanh Toán.", "Thanh Toán Bằng Tiền Mặt ");
            }
        }
    }
}
