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

namespace QuanLySach.form
{
    public partial class frmQuanLy : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        string kiemtra = "null";
        public frmQuanLy()
        {
            InitializeComponent();
            timer1.Start();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
            
        }

        private void GetDate()
        {
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            txtStart.Value = DateTime.ParseExact(ngay, "dd/MM/yyyy", null);
            txtend.Value = DateTime.ParseExact(ngay, "dd/MM/yyyy", null);
        }
        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            toolbox.Visible = false;
            paNgay.Visible = false;
            paTong.Visible = false;
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

        public void HienThiNhanVien(int check, string ma)
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                if(check == 0)
                {
                    com.CommandText = "select MaNV,HoTen,CONVERT(varchar,NgaySinh, 103)  as NgaySinh " +
                    ",GioiTinh,ChucVu,DiaChi from NhanVien";
                }
                if(check == 1)
                {
                    com.CommandText = "select MaNV,HoTen,CONVERT(varchar,NgaySinh, 103)  as NgaySinh " +
                    ",GioiTinh,ChucVu,DiaChi from NhanVien where MaNV='"+ma.Trim()+"'";
                }
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dt.Columns["MaNV"].ColumnName = "Mã Nhân Viên";
                dt.Columns["HoTen"].ColumnName = "Họ Tên ";
                dt.Columns["NgaySinh"].ColumnName = "Ngày Sinh";
                dt.Columns["GioiTinh"].ColumnName = "Giới Tính";
                dt.Columns["ChucVu"].ColumnName = "chức Vụ  ";
                dt.Columns["DiaChi"].ColumnName = "Địa chỉ";
                data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                data.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        public void HienThiKhachHang(int check, string ma)
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                if(check == 0)
                {
                    com.CommandText = "select * from KhachHang";
                }
                if (check == 1)
                {
                    com.CommandText = "select * from KhachHang where MaKH='"+ma+"'";
                }
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dt.Columns["MaKH"].ColumnName = "Mã Khách Hàng";
                dt.Columns["TenKH"].ColumnName = "Tên Khách Hàng";
                dt.Columns["GioiTinh"].ColumnName = "Giới Tính";
                dt.Columns["MaSoThue"].ColumnName = "Mã Số Thuế";
                dt.Columns["DiaChi"].ColumnName = "Địa Chỉ";
                dt.Columns["DienThoai"].ColumnName = "Điện Thoại";
                data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                data.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            kiemtra = "nhanvien";
            toolbox.Visible = true;
            paTong.Visible = false;
            HienThiNhanVien(0,"0");
            btnSearch.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (kiemtra.Equals("null"))
            {
                MessageBox.Show("Vui Lòng Chọn Thao Tác trước khi tìm kiếm ! ", "Cảnh Báo lỗi truy cập ");
            }
            else
            {
                string ma = txtSearch.Text.Trim();
                if (kiemtra.Equals("dangnhap"))
                {
                    HienThidangNhap(1, txtSearch.Text.Trim());
                }
                if (kiemtra.Equals("nhanvien"))
                {
                    HienThiNhanVien(1, ma);
                }
                if (kiemtra.Equals("khachhang"))
                {
                    HienThiKhachHang(1, ma);
                }
            }
        }
        int numrow;
        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            numrow = e.RowIndex;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
        // xóa nhân viên 
        private void XoaNhanVien()
        {
            try
            {
                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string manv = data.Rows[numrow].Cells[0].Value.ToString();
                cmd.CommandText = "delete from ThuNgan where MaNV='" +manv+ "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText= "delete from NhanVien where MaNV='" + manv + "'";
                cmd.ExecuteNonQuery();
                HienThiNhanVien(0, "0");
                MessageBox.Show("Xóa Thành Công Nhân Viên  " + manv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Xóa Nhân Viên ");

            }
        }
        // xóa đăng nhập 
        private void XoaDangNhap()
        {
            try
            {
                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string manv = data.Rows[numrow].Cells[0].Value.ToString();
                cmd.CommandText = "delete from ThuNgan where MaNV='" + manv + "'";
                cmd.ExecuteNonQuery();

                HienThidangNhap(0,"0");
                MessageBox.Show("Xóa Thành Công Nhân Viên  " + manv+". Nhân Viên Này Sẽ không Còn Đăng Nhập Hệ Thống Được Nữa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Xóa Nhân Viên ");

            }
        }
            // xóa khách hàng
        private void Xoakhachhang()
        {
            try
            {
                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string makh = data.Rows[numrow].Cells[0].Value.ToString();
                cmd.CommandText = "delete from KhachHang where MaKH='" + makh + "'";
                cmd.ExecuteNonQuery();

                HienThiKhachHang(0, "0");
                MessageBox.Show("Xóa Thành Công Khách hàng"+makh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Xóa Khách Hàng");

            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (kiemtra.Equals("nhanvien"))
            {
                XoaNhanVien();
            }
            if (kiemtra.Equals("dangnhap"))
            {
                XoaDangNhap();
            }
            if (kiemtra.Equals("khachhang"))
            {
                Xoakhachhang();
            }
        }


        // Cập nhật nhan viên 
        public void CapNhatNhanVien()
        {
            string manv = data.Rows[numrow].Cells[0].Value.ToString().Trim();
            string hoten = data.Rows[numrow].Cells[1].Value.ToString().Trim();
            string ngaysinh = data.Rows[numrow].Cells[2].Value.ToString().Trim();
            string gioitinh = data.Rows[numrow].Cells[3].Value.ToString().Trim();
            string chucvu = data.Rows[numrow].Cells[4].Value.ToString().Trim();
            string diachi = data.Rows[numrow].Cells[5].Value.ToString().Trim();
            
            // lấy dữ liệu về 
            try
            {
                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update  NhanVien set  HoTen=N'" + hoten+"', NgaySinh='"+ngaysinh
                    + "', GioiTinh ='"+gioitinh+"', ChucVu=N'"+chucvu+"',DiaChi=N'"+diachi+"'  where MaNV='" + manv + "'";
                cmd.ExecuteNonQuery();
                HienThiNhanVien(0, "0");
                MessageBox.Show("Cập Nhật Thành Công Nhân Viên  " + manv.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Cập Nhật Nhân Viên  " );

            }
        }
        // Cập nhật khách hàng
        public void CapNhatkhachhang()
        {
            string makh = data.Rows[numrow].Cells[0].Value.ToString().Trim();
            string tenkh = data.Rows[numrow].Cells[1].Value.ToString().Trim();
            string gioitinh = data.Rows[numrow].Cells[2].Value.ToString().Trim();
            string masothue  = data.Rows[numrow].Cells[3].Value.ToString().Trim();
            string diachi = data.Rows[numrow].Cells[4].Value.ToString().Trim();
            string dienthoai = data.Rows[numrow].Cells[5].Value.ToString().Trim();

            // lấy dữ liệu về 
            try
            {
                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update  KhachHang set  TenKh=N'" + tenkh + "', MaSoThue='" + masothue
                   + "', GioiTinh ='" + gioitinh + "', DienThoai=" + dienthoai + ",DiaChi=N'" + diachi + "'  where MaKH='" + makh + "'";
                cmd.ExecuteNonQuery();
                HienThiKhachHang(0,"0");
                MessageBox.Show("Cập Nhật Thành Công Thông Tin Khách Hàng" + makh.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Cập Nhật thông tin cho khách hàng ");

            }
        }

        // Cập Nhật Đang nhập
        public void CapNhatDangNhap()
        {
            string manv = data.Rows[numrow].Cells[0].Value.ToString().Trim();
            string tendn = data.Rows[numrow].Cells[1].Value.ToString().Trim();
            string pass = data.Rows[numrow].Cells[2].Value.ToString().Trim();

            // lấy dữ liệu về 
            try
            {
                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update  ThuNgan set  TenDN=N'" + tendn + "', MatKhau='" + pass
                    + "' where MaNV='" + manv + "'";
                cmd.ExecuteNonQuery();
                HienThidangNhap(0, "0");
                MessageBox.Show("Cập Nhật Thành Công Thông Tin Đăng Nhập Cho Nhân Nhân Viên  " + manv.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Cập Nhật Đăng Nhập Cho Nhân Viên  Nhân Viên  ");

            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kiemtra.Equals("nhanvien"))
            {
                CapNhatNhanVien();
            }
            if (kiemtra.Equals("dangnhap"))
            {
                CapNhatDangNhap();
            }
            if (kiemtra.Equals("khachhang"))
            {
                CapNhatkhachhang();
            }
        }

        private void HienThidangNhap(int check,string ma)
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                if(check == 0) {
                com.CommandText = "select * from ThuNgan";
                }
                if(check== 1)
                {
                    com.CommandText = "select * from ThuNgan where MaNV='"+ma.Trim()+"'";
                }
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dt.Columns["MaNV"].ColumnName = "Mã Nhân Viên";
                dt.Columns["TenDN"].ColumnName = "Tên Đăng Nhập";
                dt.Columns["MatKhau"].ColumnName = "Mật khẩu";
          
                data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                data.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show("Dữ Liệu không Hợp Thệ Hoặc Không Tìm Thấy Theo yêu cầu , Vui lòng thử lại !");
            }
        }
        private void btnquanlydangnhap_Click(object sender, EventArgs e)
        {
            kiemtra = "dangnhap";
            toolbox.Visible = true;
            paTong.Visible = false;
            HienThidangNhap(0,"0");
            btnSearch.Visible = true;
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            kiemtra = "khachhang";
            toolbox.Visible = true;
            paTong.Visible = false;
            HienThiKhachHang(0, "0");
            btnSearch.Visible = true;
        }

        string thongke = null;
        private void btnthongkenhap_Click(object sender, EventArgs e)
        {
            toolbox.Visible = false;
            btnSearch.Visible = false;
            paNgay.Visible = true;
            thongke = "nhap";
        }
        public void ThongKeNhap()
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                string start = txtStart.Value.ToString("MM/dd/yyyy").Trim();
                string end = txtend.Value.ToString("MM/dd/yyyy").Trim();
                com.CommandText = "select  pn.NgayNhap , Sum(ct.SoLuongNhap*ct.GiaNhap) as Tong from ChiTietPhieuNhap ct, " +
                    "PhieuNhap pn where ct.MaPN = pn.MaPN and pn.NgayNhap >= '"+start+"' and pn.NgayNhap <= '"+end+"' group by(pn.NgayNhap)";
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dt.Columns["NgayNhap"].ColumnName = "Ngày Nhập";
                dt.Columns["Tong"].ColumnName = "Tổng Tiền Nhập";
                data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                data.DataSource = dt;
            }
            catch (Exception es)
            {

            }
        }
        public void ThongKeXuat()
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                string start = txtStart.Value.ToString("MM/dd/yyyy").Trim();
                string end = txtend.Value.ToString("MM/dd/yyyy").Trim();
                com.CommandText = "select hd.NgayBan As N'Ngày Bán' ,Sum (ct.SoLuongBan* ct.GiaBan) as N'Tổng Tiền Bán' from ChiTietHoaDon ct," +
                    " HoaDon hd where ct.SoHD = hd.SoHD and hd.NgayBan >= '"+start+"' and hd.NgayBan <= '"+end+"' group by(hd.NgayBan)";
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                //dt.Columns["NgayNhap"].ColumnName = "Ngày Nhập";
                //dt.Columns["Tong"].ColumnName = "Tổng Tiền Nhập";
                data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                data.DataSource = dt;
            }
            catch (Exception es)
            {

            }
        }
        private void btnThongKeXuat_Click(object sender, EventArgs e)
        {
            toolbox.Visible = false;
            btnSearch.Visible = false;
            paNgay.Visible = true;
            thongke = "xuat";
        }
        public void HienThiTong()
        {
            double tong = 0;
            for( int i  = 0; i<(data.RowCount - 1); i++)
            {
                double tien = double.Parse(data.Rows[i].Cells[1].Value.ToString());
                tong = tong + tien;
            }
            laTongTien.Text = tong.ToString();
        }



        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (thongke.Equals("nhap"))
            {
                ThongKeNhap();
                HienThiTong();
                paTong.Visible = true;
                paNgay.Visible = false;
            }else if (thongke.Equals("xuat"))
            {
                ThongKeXuat();
                HienThiTong();
                paTong.Visible = true;
                paNgay.Visible = false;
            }
        }

        //
    }
}
