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

namespace QuanLySach
{
    public partial class frmHoaDon : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        int kiemtra = 0;
        public frmHoaDon()
        {
            InitializeComponent();
            timer1.Start();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
        }

        private void btnDeleteAllHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("HH:mm");
            labSecons.Text = DateTime.Now.ToString("ss");
            labday.Text = DateTime.Now.ToString("dddd");
            labDayMonthYear.Text = DateTime.Now.ToString("dd : MM : yyyy");
        }

        public void HienThi()
        {
          
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "select SoHD,CONVERT(varchar,NgayBan, 103) as NgayBan from HoaDon";
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dt.Columns["SoHD"].ColumnName = "Số Hóa Đơn";
                dt.Columns["NgayBan"].ColumnName = "Ngày Bán";
                
                dataHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataHoaDon.DataSource = dt;
            }
            catch (Exception ex) { }

        }
        private void btnCTHD_Click(object sender, EventArgs e)
        {
            HienThiCTHD();
            kiemtra = 1;
            toolbox.Visible = true;
            toolbox.Text = "ToolBox Chi Tiết Hóa Đơn";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (kiemtra == 0)
            {
                try
                {
                    String caulenh = "select SoHD,CONVERT(varchar,NgayBan, 103) as NgayBan from HoaDon where SoHD='" + txtSearch.Text.ToString().Trim() + "'";
                    SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                    DataTable dt = new DataTable();
                    sqldata.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        dt.Columns["SoHD"].ColumnName = "Mã Hóa Đơn";
                        dt.Columns["NgayBan"].ColumnName = "Ngày Bán";
                        dataHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataHoaDon.DataSource = dt;
                    }
                    else { MessageBox.Show("Không Tìm Thấy Dữ Liệu Hóa Đơn . Vui Lòng kiểm tra lại !"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gặp Lỗi Khi Truy Xuất ! Vui lòng thử lại", "Lỗi Search");
                }
            }
            else if (kiemtra == 1)
            {
                try
                {
                    String caulenh = "select* ,(SoLuongBan*GiaBan) as Tong from ChiTietHoaDon where  SoHD='" + txtSearch.Text.ToString().Trim() + "' or MaKh" +
                        "='" + txtSearch.Text.ToString().Trim()+"'";
                    SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                    DataTable dt = new DataTable();
                    sqldata.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        dt.Columns["SoHD"].ColumnName = "Mã Hóa Đơn";
                        dt.Columns["MaSach"].ColumnName = "Mã Sách";
                        dt.Columns["SoLuongBan"].ColumnName = "Số Lượng Bán";
                        dt.Columns["MaKH"].ColumnName = "Mã Khách Hàng";
                        dt.Columns["GiaBan"].ColumnName = "Giá Bán";
                        dt.Columns["Tong"].ColumnName = "Tổng Tiền ";
                        dataHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataHoaDon.DataSource = dt;
                    }
                    else { MessageBox.Show("Không Tìm Thấy Dữ Liệu CT Hóa Đơn. Vui Lòng kiểm tra lại !"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gặp Lỗi Khi Truy Xuất ! Vui lòng thử lại", "Lỗi Search");
                }
            }
        }

        private void btnDSHD_Click(object sender, EventArgs e)
        {
            kiemtra = 0;
            HienThi();
            toolbox.Visible = true;
            toolbox.Text = "ToolBox Hóa Đơn";

        }

        private void btnAddHD_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                string ngayban = txtNgayBan.Value.ToString("MM/dd/yyyy").Trim();
                string sql = "insert into HoaDon(SoHD, NgayBan)" +
                " values('" + txtMaHD.Text.Trim() + "','" + ngayban + "')";
                com.CommandText = sql;
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                MessageBox.Show("Hóa Đơn " + txtMaHD.Text.Trim() + " Được thêm Vào Hệ Thống. Bạn Có Thể Thêm Chi Tiết Hóa Đơn ở Bên Dưới ", "Thêm TG Thành Công");
                HienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có Lỗi Xảy Ra Vui Lòng Thử lại ");
            }
        }

        public void HienThiCTHD()
        {
            kiemtra = 1;
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "select * ,(SoLuongBan*GiaBan) as Tong from ChiTietHoaDon";
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dt.Columns["SoHD"].ColumnName = "Số Hóa Đơn";
                dt.Columns["MaSach"].ColumnName = "Mã Sách";
                dt.Columns["SoLuongBan"].ColumnName = "Số Lượng Bán";
                dt.Columns["GiaBan"].ColumnName = "Giá Bán";
                dt.Columns["MaKH"].ColumnName = "Mã Khách hàng";
                dt.Columns["Tong"].ColumnName = "Tổng Tiền ";
                dataHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataHoaDon.DataSource = dt;
            }
            catch (Exception ex) { }
        }
        private void btnAddCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                string sql = "insert into ChiTietHoaDon(SoHD, MaSach, SoLuongBan, GiaBan,MaKH)" +
                " values('" + txtMaCTHD.Text.Trim() + "','" + txtMaSach.Text.Trim() + "'," + txtSLB.Text.Trim() + "," + txtGiaBan.Text.Trim() +",'"+
                txtMaKhachhang.Text.Trim()+"')";
                com.CommandText = sql;
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                MessageBox.Show("Phiếu CT Hóa Đơn Được thêm Vào Hệ Thống.  ", "Thêm CT HD Thành Công");
                HienThiCTHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có Lỗi Xảy Ra Vui Lòng Thử lại ");
            }
        }

        private void btnDeleteAllCT_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtSLB.Clear();
            txtGiaBan.Clear();
            txtMaKhachhang.Clear();
        }

        private void txtMaCTHD_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaCTHD.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            toolbox.Visible = false;
        }

        private void dataHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (kiemtra == 0)
            {
                toolbox.Visible = true;
                toolbox.Text = "ToolBox Hóa Đơn";
                string ngaytam;
                ngaytam = dataHoaDon.Rows[numrow].Cells[1].Value.ToString();
                ngaytam.Trim();
                for (int i = 0; i < ngaytam.Length; i++)
                {
                    if (ngaytam[i] == ' ')
                    {
                        ngaytam = ngaytam.Substring(0, i);
                    }
                }
                txtMaHD.Text = dataHoaDon.Rows[numrow].Cells[0].Value.ToString();
                DateTime date = DateTime.ParseExact(ngaytam, "dd/MM/yyyy", null);
                txtNgayBan.Value = date;
                
            }
            else if (kiemtra == 1)
            {
                toolbox.Visible = true;
                toolbox.Text = "ToolBox Chi Tiết Hóa Đơn";
                txtMaCTHD.Text = dataHoaDon.Rows[numrow].Cells[0].Value.ToString();
                txtMaSach.Text = dataHoaDon.Rows[numrow].Cells[1].Value.ToString();
                txtSLB.Text = dataHoaDon.Rows[numrow].Cells[2].Value.ToString();
                txtGiaBan.Text = dataHoaDon.Rows[numrow].Cells[3].Value.ToString();
                txtMaKhachhang.Text = dataHoaDon.Rows[numrow].Cells[4].Value.ToString();

            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            txtMaCTHD.Text = txtMaHD.Text;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kiemtra == 0)
            {
                try
                {
                    string ngayNhapUpdate = txtNgayBan.Value.ToString("MM/dd/yyyy").Trim();
                    SqlCommand cmd = ketnoi.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  HoaDon set NgayBan='" + ngayNhapUpdate +"' where SoHD='" + txtMaHD.Text.ToString().Trim() + "'";
                    cmd.ExecuteNonQuery();
                    HienThi();
                    MessageBox.Show("Cập Nhật Thành Công Hóa Đơn " + txtMaHD.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Khi Cập Nhật Phiếu Nhập " + txtMaHD.Text);

                }

            }
            else if (kiemtra == 1)
            {
                try
                {
                    SqlCommand cmd = ketnoi.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  ChiTietHoaDon set MaSach ='" + txtMaSach.Text.ToString().Trim()
                        + "', SoLuongBan=" + txtSLB.Text.ToString().Trim() + ",GiaBan=" + txtGiaBan.Text.ToString().Trim()
                        + " where SoHD='" + txtMaCTHD.Text.ToString().Trim() + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập Nhật Thành Công Chi Tiết Hóa Đơn " + txtMaCTHD.Text);
                    HienThiCTHD();
                }
                catch (Exception ec)
                {
                    MessageBox.Show("Lỗi Khi Cập Nhật Chi Tiết Hóa Đơn " + txtMaCTHD.Text);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (kiemtra == 0)
            {
                try
                {
                    SqlCommand cmd = ketnoi.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from HoaDon where SoHD='" + txtMaHD.Text.Trim() + "'";
                    cmd.ExecuteNonQuery();
                    HienThi();
                    MessageBox.Show("Xóa Thành Công Hóa Đơn  " + txtMaHD.Text);
                    txtMaHD.Clear();
                    DateTime dt = DateTime.Now;
                    txtNgayBan.Value = dt;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Khi Xóa Hóa Đơn " + txtMaHD.Text);

                }
            }
            else if (kiemtra == 1)
            {
                try
                {
                    SqlCommand cmd = ketnoi.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from ChiTietHoaDon where SoHD='" + txtMaCTHD.Text.Trim() + "'";
                    cmd.ExecuteNonQuery();
                    HienThiCTHD();
                    MessageBox.Show("Xóa Thành Công Chi Tiết  Hóa Đơn " + txtMaCTHD.Text);
                    txtMaCTHD.Clear();
                    txtMaSach.Clear();
                    txtMaSach.Clear();
                    txtGiaBan.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Khi Xóa  Chi Tiết Hóa Đơn " + txtMaCTHD.Text);

                }
            }
        }
    }
}
