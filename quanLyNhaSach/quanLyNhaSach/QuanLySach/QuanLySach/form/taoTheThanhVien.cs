using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QRCoder;

namespace QuanLySach
{
    public partial class taoTheThanhVien : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        public taoTheThanhVien()
        {
            InitializeComponent();
            timer1.Start();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("HH:mm");
            labSecons.Text = DateTime.Now.ToString("ss");
            labday.Text = DateTime.Now.ToString("dddd");
            labDayMonthYear.Text = DateTime.Now.ToString("dd : MM : yyyy");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKh.Clear();
            txtMaSoThue.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();

        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "" || txtTenKh.Text.Trim() == ""
               || (raNam.Checked == false && raNu.Checked == false && raKhac.Checked == false)
               || txtDiaChi.Text.Trim() == "" || txtDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Điền Đầy đủ Thông Tin !");

            }
            else
            {
                int test = 0;
                try
                {
                    int sodt = Convert.ToInt32(txtDienThoai.Text.Trim());
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("Số Điện Thoại Là Một Dãy Số");
                    txtDienThoai.Focus();
                    test = 1;
                }
                if (test == 0)
                {
                    try
                    {
                        SqlCommand com = ketnoi.CreateCommand();
                        com.CommandType = CommandType.Text;
                        string gioitinh = null;
                        if (raNam.Checked == true)
                        {
                            gioitinh = "M";
                        }
                        else if (raNu.Checked == true)
                        {
                            gioitinh = "F";
                        }
                        else if (raKhac.Checked == true)
                        {

                            gioitinh = "K";
                        }

                        string sql = "insert into KhachHang(MaKH, TenKH, GioiTinh, MaSoThue, DiaChi, DienThoai)" +
                        " values('" + txtMaKH.Text.Trim() + "',N'" + txtTenKh.Text.Trim() + "','" + gioitinh + "','" +
                        txtMaSoThue.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "'," + txtDienThoai.Text.Trim() + ")";
                        com.CommandText = sql;
                        com.Connection = ketnoi;
                        com.ExecuteNonQuery();
                        MessageBox.Show("Khách Hàng " + txtTenKh.Text.Trim() + " Được thêm Vào Hệ Thống.  ", "Thêm KH Thành Công");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có Lỗi Xảy Ra Vui Lòng Thử lại ");
                    }
                }
            }
        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mã Khách Hàng Cần Tạo Thẻ !", "Lỗi");
            }
            else
            {
                String caulenh = "select * from KhachHang where MaKH='" + txtMaKH.Text.Trim() + "'";
                SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                string data = txtMaKH.Text.Trim();
                if (dt.Rows.Count == 1)
                {
                    QRCodeGenerator qr = new QRCodeGenerator();
                    QRCodeData data1 = qr.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                    QRCode code = new QRCode(data1);
                    pictureBox1.Image = code.GetGraphic(11);
                }
                else
                {
                    MessageBox.Show("Mã Khách Hàng Không Đúng Hoặc Không Tồn Tại . Xin Vui Lòng Thử Lại !", "" +
                        "Lost Create card Member!");
                }
            }
        }

        private void btnsearchIDCustomer_Click(object sender, EventArgs e)
        {
            txtsearchIDCustomer.Clear();
        }

        private void txtsearchIDCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ma = txtsearchIDCustomer.Text.Trim();
            customer cu = new customer();
            Boolean  bl = cu.GetIDCustomer(ma);
            if (bl) { txtMaKH.Text = ma.Trim(); }
            else { MessageBox.Show("Mã Khách Hàng Không Tồn Tại !"); }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = DateTime.Now.ToString("ssmmHHddMMyyyy");
        }
    }
}
