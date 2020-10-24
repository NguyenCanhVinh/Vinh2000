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
using System.Data.Sql;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using QuanLySach.form;

namespace QuanLySach
{
    public partial class main : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dtbanhang = new DataTable("ban_hang");
        public string maThuNgan="";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public main()
        {
            InitializeComponent();
            DefaltSubMenu();
            timer1.Start();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
            lenh.Connection = ketnoi;
            GetDate();
         //this.FormBorderStyle = FormBorderStyle.None;
           Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(5, 5, Width, Height, 50, 50));
            //checkDisplay();

        }
        
        public void checkDisplay()
        {
            Hierarchy hie = new Hierarchy();
            string tam = hie.getH();
            string cvName = hie.getCV(tam).Trim();
            if (cvName.Equals("Quản Lý"))
            {
                
            }
            else
            {
                
                btnthemnhanvien.Visible = false;
                btnQuanLy.Visible = false;
            }

        }
        private void GetDate()
        {
           string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            txtNgayBan.Value = DateTime.ParseExact(ngay, "dd/MM/yyyy", null);
        }
        
        public void ShowNameThuNgan()
        {
           // maThuNgan = labThuNgan.Text.ToString().Trim();
            string sql = "select HoTen from NhanVien where MaNV='" + maThuNgan + "'";
            SqlDataAdapter sqldata = new SqlDataAdapter(sql, ketnoi);
            DataTable dt = new DataTable();
            sqldata.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                string ten = dt.Rows[0]["HoTen"].ToString().Trim();
                labThuNgan.Text = ten;
            }
        }
        public void GETVALUE( string value)
        {
            txtThanhVien.Text = value;
        }
       
        private void DefaltSubMenu()
        {
            //chay mac dinh la no anh di 
            panelHomeSubMenu.Visible = false;
            panelSubSecons.Visible = false;
            // hide sub menu 
        }
        private void HideSubMenu()
        {
            if (panelHomeSubMenu.Visible == true)
            {
                panelHomeSubMenu.Visible = false;
            }
            if (panelSubSecons.Visible == true)
            {
                panelSubSecons.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panelHomeSubMenu);
        }
        private Form activeForm = null;
        private void openWorkForm(Form workForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = workForm;
            workForm.TopLevel = false;
            workForm.FormBorderStyle = FormBorderStyle.None;
            workForm.Dock = DockStyle.Fill;
            panelWorkMain.Controls.Add(workForm);
            panelWorkMain.Tag = workForm;
            workForm.BringToFront();
            workForm.Show();
        }

        private void btnCreateMenberShip_Click(object sender, EventArgs e)
        {
            openWorkForm(new taoTheThanhVien());
            HideSubMenu();
        }
        //Thoi Gian Form Main 

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("HH:mm");
            labSecons.Text = DateTime.Now.ToString("ss");
            labday.Text = DateTime.Now.ToString("dddd");
            labDayMonthYear.Text = DateTime.Now.ToString("dd : MM : yyyy");
        }

        private void txtMahang_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMahang_MouseClick(object sender, MouseEventArgs e)
        {
            txtMahang.Clear();
            txtSoLuong.Value = 1;
            txtMahang.ForeColor = Color.Black;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtThanhVien.Clear();
            txtThanhVien.ForeColor = Color.Black;
        }

        private void btnscanidbook_Click(object sender, EventArgs e)
        {
            frmBarcode bar = new frmBarcode();
            bar.mahang = new frmBarcode.GETDATAMAHANG(GETMAHANG);
            bar.Show();
        }

        private void btndangxuat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubSecons);
        }

        private void btnthemnhanvien_Click(object sender, EventArgs e)
        {
            Hierarchy hie = new Hierarchy();
            string cvName = hie.getCV(maThuNgan).Trim();
            if (cvName.Equals("Quản Lý"))
            {
                openWorkForm(new frmThemNhanVien());
                HideSubMenu();
            }
            else
            {
                MessageBox.Show("Bạn Không Thể Thực Hiện Thao Tác Này . Liên Hệ Quản Lý Để Hỗ Trợ !", "Lỗi Truy Cập !");
                //btnthemnhanvien.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void btnscanidkhachhang_Click(object sender, EventArgs e)
        {
         
            ScanQrcodes sc = new ScanQrcodes();
            sc.nhan = "main";
            sc.mydata = new ScanQrcodes.GETDATA(GETVALUE);
            sc.Show();
            sc.button2.Visible = false;
        }

        public void IdKhachhang(String makh)
        {
            String caulenh = "select TenKH from KhachHang where MaKh='"+makh+"'";
            SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
            DataTable dt = new DataTable();
            sqldata.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                txtTenKH.Text = dt.Rows[0]["TenKH"].ToString();
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Mã Khách Hàng Vui Lòng Thử Lại !", "" +
                    "Lỗi truy xuất!");
            }
        }
       
        private void btnOkKH_Click(object sender, EventArgs e)
        {
            if(txtThanhVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn Chưa nhập ID Khách Hàng");
            }
            else
            {
                String kh = txtThanhVien.Text.Trim();
                IdKhachhang(kh);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openWorkForm(new frmTacGia());
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openWorkForm(new frmNhaXuatBan());
            HideSubMenu();
        }

        private void btnAddTheLoai_Click(object sender, EventArgs e)
        {
            openWorkForm(new frmTheLoai());
            HideSubMenu();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string masach = txtMahang.Text.Trim();
            TimKiemSach(masach);
            
        }

        public void TimKiemSach(string masach)
        {
            lenh.CommandText = "select sc.MaSach,sc.TenSach,sc.SoLuong,sc.TenSach as SLBan, sc.DonGia,sc.TenSach as GiamGia, sc.TenSach as ThanhTien from Sach sc where MaSach='" +masach + "'";
            lenh.Parameters.Clear();
            da.SelectCommand = lenh;
            //dtbanhang.Clear();
            da.Fill(dtbanhang);
            int i = dtbanhang.Rows.Count-1;
               int soluong = (int)txtSoLuong.Value;
                dtbanhang.Rows[i]["SLBan"] = soluong + "";
                dtbanhang.Rows[i]["GiamGia"] = "";
                double thanhtien = 0;
            double gg;
            if (dtbanhang.Rows[i]["GiamGia"].ToString() == "")
            {
                gg = 0;
            }
            else { gg = Convert.ToDouble(dtbanhang.Rows[i]["DonGia"].ToString()); }
                double dg = Convert.ToDouble(dtbanhang.Rows[i]["DonGia"].ToString());
                thanhtien = (double)soluong * dg - (double)soluong * dg*gg /100 ;
                dtbanhang.Rows[i]["ThanhTien"] = thanhtien + "";
            double Tongtien = 0;
            for(int j =0; j< dtbanhang.Rows.Count; j++)
            {
                Tongtien += Convert.ToDouble(dtbanhang.Rows[j]["ThanhTien"].ToString());
            }
            txtTongtien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tongtien.ToString().Trim());
            //da.Fill(dtbanhang);
            dataBanHang.DataSource = dtbanhang;
            
        }
     
        private void btnAddSach_Click(object sender, EventArgs e)
        {
            openWorkForm(new frmAddSach());
            HideSubMenu();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            openWorkForm(new frmPhieuNhap());
            HideSubMenu();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            openWorkForm(new frmHoaDon());
            HideSubMenu();
        }

        public void GETMONEY(string values)
        {
            txtKhachDua.Text = values;
        }
        public void GETMAHANG(string values)
        {
            txtMahang.Text = values;
            TimKiemSach(values.Trim());
        }

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
           
            if (txtSoHD.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Số Hóa Đơn Cho Đơn Hàng Này ");
            }
            else
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                int kiemtra = 0;
                //
                for (int i = 0; i < (dataBanHang.Rows.Count - 1); i++)
                {
                    string maSach = dataBanHang.Rows[i].Cells["MaSach"].Value.ToString().Trim();
                    string manv = maThuNgan.Trim();
                    string makHTam = txtTenKH.Text.Trim();
                    string makh;
                    if (makHTam == "" || makHTam == null)
                    {
                        makh = "";
                    }
                    else
                    {
                        makh = txtThanhVien.Text.ToString().Trim();
                    }

                    string sohd = DateTime.Now.ToString("ssmmHHddMMyyyy").Trim();
                    string slt = dataBanHang.Rows[i].Cells["Soluong"].Value.ToString().Trim();
                    string slb = dataBanHang.Rows[i].Cells["SLBan"].Value.ToString().Trim();
                    string giaBan = dataBanHang.Rows[i].Cells["DonGia"].Value.ToString().Trim();
                    string GiamGia = dataBanHang.Rows[i].Cells["GiamGia"].Value.ToString().Trim();
                    string ThanhTien = dataBanHang.Rows[i].Cells["ThanhTien"].Value.ToString().Trim();
                    string makhachhang = txtThanhVien.Text.Trim();

                    try
                    {
                        //thực hiện cập nhật hóa đơn 
                        if (i == 0)
                        {
                            string ngayban = txtNgayBan.Value.ToString("MM/dd/yyyy").Trim();
                            string sql1 = "insert into HoaDon(SoHD, NgayBan)" +
                                    " values('" + txtSoHD.Text.Trim() + "','" + ngayban + "')";
                            com.CommandText = sql1;
                            com.Connection = ketnoi;
                            com.ExecuteNonQuery();
                        }

                        // cập nhật cho chitiet hóa đơn 


                       // string sql2 = "insert into ChiTietHoaDon(SoHD, MaSach, SoLuongBan, GiaBan,MaKH) values ('" + txtSoHD.Text.Trim() + "','" +
                      //  maSach + "'," + slb + "," + giaBan + ",'"+makhachhang+"')";
                       // SqlCommand com2 = ketnoi.CreateCommand();
                       // com2.CommandText = sql2;
                        //com2.Connection = ketnoi;
                        //com2.ExecuteNonQuery();

                        ///
                        if (GiamGia == null || GiamGia == "")
                        {
                            GiamGia = 0 + "";
                        }
                        if (makh == "" || makh == null)
                        {
                            string sql2 = "insert into ChiTietHoaDon(SoHD, MaSach, SoLuongBan, GiaBan) values ('" + txtSoHD.Text.Trim() + "','" +
                       maSach + "'," + slb + "," + giaBan +  ")";
                            SqlCommand com2 = ketnoi.CreateCommand();
                            com2.CommandText = sql2;
                            com2.Connection = ketnoi;
                            com2.ExecuteNonQuery();
                            //
                            string sql = "insert into SachBan(MaSach,MaNV,SoHD,SoLuongTonKho,SoLuongSachBan,GiaBan,GiamGia,TongTien)" +
                           "values('" + maSach + "','" + manv + "','" + txtSoHD.Text.Trim() + "'," + slt + "," + slb + "," + giaBan + "," + GiamGia + "," + ThanhTien + ")";
                            com.CommandText = sql;
                            com.Connection = ketnoi;
                            com.ExecuteNonQuery();
                            // MessageBox.Show("Thanh Toán Đơn Hàng Thành Công ! Cảm Ơn Đã Mua Hàng  ", "Thanks You!");
                            kiemtra = 1;
                        }
                        else
                        {
                            string sql2 = "insert into ChiTietHoaDon(SoHD, MaSach, SoLuongBan, GiaBan,MaKH) values ('" + txtSoHD.Text.Trim() + "','" +
                       maSach + "'," + slb + "," + giaBan + ",'" + makh + "')";
                            SqlCommand com2 = ketnoi.CreateCommand();
                            com2.CommandText = sql2;
                            com2.Connection = ketnoi;
                            com2.ExecuteNonQuery();

                            //
                            string sql = "insert into SachBan(MaSach,MaNV,MaKH,SoHD,SoLuongTonKho,SoLuongSachBan,GiaBan,GiamGia,TongTien)" +
                           "values('" + maSach + "','" + manv + "','" + makh + "','" + txtSoHD.Text.Trim() + "'," + slt + "," + slb + "," + giaBan + "," + GiamGia + "," + ThanhTien + ")";
                            com.CommandText = sql;
                            com.Connection = ketnoi;
                            com.ExecuteNonQuery();
                            // MessageBox.Show("Thanh Toán Đơn Hàng Thành Công ! Cảm Ơn Đã Mua Hàng  ", "Thanks You!");
                            kiemtra = 2;
                        }
                    }
                    catch (Exception ex)
                    {
                        kiemtra = 0;
                    }
                }

                //
                if (kiemtra == 0)
                {
                    MessageBox.Show("Hệ Thống Gặp Lỗi Khi Thanh Toán Đơn Hàng Này ! Vui lòng thử Lại. ");
                }
                else if (kiemtra == 1 || kiemtra == 2)
                {
                    MessageBox.Show("Thanh Toán Đơn Hàng Thành Công ! Cảm Ơn Đã Mua Hàng  ", "Thanks You!");
                }
                //

                //
            }

        }

        private void main_Load(object sender, EventArgs e)
        {
            txtSoHD.Text= DateTime.Now.ToString("ssmmHHddMMyyyy");
            Hierarchy hie = new Hierarchy();
            string cvName = hie.getCV(maThuNgan).Trim();
            if (cvName.Equals("Quản Lý"))
            {
               // openWorkForm(new frmQuanLy());
                HideSubMenu();
            }
            else
            {
                //MessageBox.Show("Bạn Không Thể Thực Hiện Thao Tác Này . Liên Hệ Quản Lý Để Hỗ Trợ !", "Lỗi Truy Cập !");
                 btnQuanLy.Visible = false;
                btnthemnhanvien.Visible = false;
            }
        }
        
     
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            Hierarchy hie = new Hierarchy();
            string cvName = hie.getCV(maThuNgan).Trim();
            if (cvName.Equals("Quản Lý"))
            {
                openWorkForm(new frmQuanLy());
                HideSubMenu();
            }
            else
            {
                MessageBox.Show("Bạn Không Thể Thực Hiện Thao Tác Này . Liên Hệ Quản Lý Để Hỗ Trợ !", "Lỗi Truy Cập !");
               // btnQuanLy.Visible = false;
            }
        }

  

        private void dataBanHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double giamgia;
            double tong = 0;
            for (int counter = 0; counter < (dataBanHang.Rows.Count-1);
                 counter++)
            {
                if (dataBanHang.Rows[counter].Cells["GiamGia"].Value.ToString() == "")
                {
                    giamgia = 0;
                    double soluong = double.Parse(dataBanHang.Rows[counter].Cells["SLBan"].Value.ToString());
                    
                    double dongia = double.Parse(dataBanHang.Rows[counter].Cells["DonGia"].Value.ToString());
                    tong = soluong * dongia;
                    dataBanHang.Rows[counter].Cells["ThanhTien"].Value = tong.ToString();
                    //txtTongtien.Text = tong + "";
                    double Tongtien = 0;
                    for (int j = 0; j < dtbanhang.Rows.Count; j++)
                    {
                        Tongtien += Convert.ToDouble(dtbanhang.Rows[j]["ThanhTien"].ToString());
                    }
                    txtTongtien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tongtien.ToString().Trim());

                    //
                }
                else
                {
                    giamgia = double.Parse(dataBanHang.Rows[counter].Cells["GiamGia"].Value.ToString());
                    double soluong = double.Parse(dataBanHang.Rows[counter].Cells["SLBan"].Value.ToString());
                    double dongia = double.Parse(dataBanHang.Rows[counter].Cells["DonGia"].Value.ToString());
                    tong = soluong * dongia - ((soluong * dongia * giamgia) / 100);
                    dataBanHang.Rows[counter].Cells["ThanhTien"].Value = tong.ToString();
                    //////txtTongtien.Text = tong + "";
                    double Tongtien = 0;
                    for (int j = 0; j < dtbanhang.Rows.Count; j++)
                    {
                        Tongtien += Convert.ToDouble(dtbanhang.Rows[j]["ThanhTien"].ToString());
                    }
                    txtTongtien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", Tongtien.ToString().Trim());
                    //
                }
            }
         }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMahang.Clear();
            txtThanhVien.Clear();
            txtKhachDua.Clear();
            txtTenKH.Clear();
            txtTongtien.Clear();
            txtTralai.Clear();
            dtbanhang.Clear();
            dataBanHang.DataSource = dtbanhang;
            txtSoHD.Text = DateTime.Now.ToString("ssmmHHddMMyyyy");
        }

        private void btnTienMat_Click(object sender, EventArgs e)
        {

            frmThanhToanTien tt = new frmThanhToanTien();
            tt.tinhtien = new frmThanhToanTien.GETDATATINHTIEN(GETMONEY);
            tt.Show();
            
            //string totalmoney = txtTongtien.Text.Trim();
            //string customermoney = txtKhachDua.Text.Trim();

        }

        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            string totalmoney = txtTongtien.Text.Trim();
            string customermoney = txtKhachDua.Text.Trim();
            if (customermoney == "" || customermoney == null)
                {
                   // txtTralai.Text = Convert.ToDouble(txtKhachDua.Text.Trim()) - Convert.ToDouble(txtTongtien.Text.Trim()) + "";
            }
            else
            {
                try
                {
                    txtTralai.Text = Convert.ToDouble(txtKhachDua.Text.Trim()) - Convert.ToDouble(txtTongtien.Text.Trim()) + "";
                }catch(Exception ed)
                {
                    MessageBox.Show("Đơn Hàng Chưa Được Tạo !");
                    txtKhachDua.Clear();
                }
            }      
        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {
            string totalmoney = txtTongtien.Text.Trim();
            string customermoney = txtKhachDua.Text.Trim();
            if (customermoney == "" || customermoney == null)
            {
                // txtTralai.Text = Convert.ToDouble(txtKhachDua.Text.Trim()) - Convert.ToDouble(txtTongtien.Text.Trim()) + "";
            }
            else
            {
                try
                {
                    txtTralai.Text = Convert.ToDouble(txtKhachDua.Text.Trim()) - Convert.ToDouble(txtTongtien.Text.Trim()) + "";
                }
                catch (Exception ed)
                {
                    MessageBox.Show("Đơn Hàng Chưa Được Tạo !");
                    txtKhachDua.Clear();
                }

                //
            }
        }

        private void btnAubout_Click(object sender, EventArgs e)
        {
            openWorkForm(new frmAboutUs());
            HideSubMenu();
        }
    }
}
