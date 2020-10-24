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
    public partial class frmThemNhanVien : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        int kiemtra = 0;
        public frmThemNhanVien()
        {
            InitializeComponent();
            timer1.Start();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("HH:mm");
            labSecons.Text = DateTime.Now.ToString("ss");
            labday.Text = DateTime.Now.ToString("dddd");
            labDayMonthYear.Text = DateTime.Now.ToString("dd : MM : yyyy");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoThe_Click(object sender, EventArgs e)
        {
            if(txtMaNv.Text.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên Cần Tạo Thẻ !", "Lỗi");
            }
            else
            {
                String caulenh = "select * from ThuNgan where MaNV='" + txtMaNv.Text.Trim() +"'";
                SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                string data = txtMaNv.Text.Trim();
                if (dt.Rows.Count == 1)
                {
                    QRCodeGenerator qr = new QRCodeGenerator();
                    QRCodeData data1 = qr.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                    QRCode code = new QRCode(data1);
                    pictureBox1.Image = code.GetGraphic(11);
                }
                else
                {
                    MessageBox.Show("Mã Nhân Viên Này Không Thể Thực hiện Tạo Thẻ Đăng Nhập . Xin Vui Lòng Liên Hệ Quản lý Cấp Quyền !", "" +
                        "Lost Create card Member!");
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            txtMaNv.Clear();
            txtTenNV.Clear();
            
            txtDiaChi.Clear();
            
        }

        private void btnAddNhanVien_Click(object sender, EventArgs e)
        {
            if (txtMaNv.Text.Trim()== "" || txtTenNV.Text.Trim() == ""
                || (raNam.Checked == false && raNu.Checked == false && raKhac.Checked == false) 
                || txtDiaChi.Text.Trim() == "" || txtChucVu.SelectedIndex == -1  )
            {
                MessageBox.Show("Vui Lòng Điền Đầy đủ Thông Tin !");
            }
            else
            {
                try
                {
                    SqlCommand com = ketnoi.CreateCommand();
                    com.CommandType = CommandType.Text;
                    string ngaysinh = txtNgaySinh.Value.ToString("MM/dd/yyyy").Trim();
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
                    string chucvu = this.txtChucVu.GetItemText(this.txtChucVu.SelectedItem);
                    string sql = "insert into NhanVien(MaNV, HoTen, NgaySinh, GioiTinh, ChucVu, Diachi)" +
                    " values('" + txtMaNv.Text.Trim() + "',N'" + txtTenNV.Text.Trim() + "','" + ngaysinh + "','" +
                    gioitinh + "',N'" + chucvu + "',N'" + txtDiaChi.Text.Trim() + "')";
                    com.CommandText = sql;
                    com.Connection = ketnoi;
                    com.ExecuteNonQuery();
                    
                    MessageBox.Show("Nhân Viên " + txtTenNV.Text.Trim() + " Được thêm Vào Hệ Thống. ", "Thêm Nhân Viên Thành Công");
                    kiemtra = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có Lỗi Xảy Ra Vui Lòng Thử lại ");
                }
            }
        }

        private void txtsearchNV_Click(object sender, EventArgs e)
        {
            txtsearchNV.Clear();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            string ma = txtsearchNV.Text.Trim();
            customer cu = new customer();
            Boolean bl = cu.GetIDNV(ma);
            if (bl)
            {
                txtMaNv.Text = ma;
                
            }
            else
            {
                MessageBox.Show("Vui Lòng kiểm Tra lại Mã Nhân Viên !", "Lỗi -errow ");
            }
        }


        
        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            txtcreateLogin.Visible = false;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void txtChucVu_Click(object sender, EventArgs e)
        {
            string chucvu = this.txtChucVu.GetItemText(this.txtChucVu.SelectedItem);
            if (chucvu.Trim().Equals("Thu Ngân") || chucvu.Trim().Equals("Quản Lý"))
            {
                txtcreateLogin.Visible = true;
            }
            else { txtcreateLogin.Visible = false; }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            txtcreateLogin.Visible = false;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                string sql = "insert into ThuNgan(MaNV, TenDN,MatKhau)" +
                        " values('" + txtMaNv.Text.Trim() + "','" + txtUsername.Text.Trim() + "','" + txtPassword.Text.Trim() + "')";
                com.CommandText = sql;
                com.Connection = ketnoi;
                com.ExecuteNonQuery();

                MessageBox.Show("Nhân Viên " + txtTenNV.Text.Trim() + " Có thể Đăng Nhập hệ Thống ", "Thêm Nhân Viên Thành Công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gặp Lỗi khi thêm Nhân Viên Này .");
            }
        }

        private void txtChucVu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string chucvu = this.txtChucVu.GetItemText(this.txtChucVu.SelectedItem);
            if (chucvu.Trim().Equals("Thu Ngân") || chucvu.Trim().Equals("Quản Lý"))
            {
                txtcreateLogin.Visible = true;
            }
            else { txtcreateLogin.Visible = false; }
        }

       
    }
}
