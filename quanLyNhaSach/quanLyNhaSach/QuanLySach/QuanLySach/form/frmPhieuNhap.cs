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
    public partial class frmPhieuNhap : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        int kiemtra = 0;
        public frmPhieuNhap()
        {
            InitializeComponent();
            timer1.Start();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
        }

        private void btnDeleteAllPN_Click(object sender, EventArgs e)
        {
            txtMaPN.Clear();
            txtMaNXB.Clear();
           
        }

        private void txtMaPN_TextChanged(object sender, EventArgs e)
        {
            txtMaCTPN.Text = txtMaPN.Text.Trim();
        }

        private void btnDeleteAllCT_Click(object sender, EventArgs e)
        {
            // txtMaCTPN.Clear();
            txtMaSach.Clear();
            txtSLN.Clear();
            txtGiaNhap.Clear();
        }

        private void txtMaCTPN_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaCTPN.Clear();
        }

        private void btnAddPN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                string ngaynhap = txtNgayNhap.Value.ToString("MM/dd/yyyy").Trim();
                string sql = "insert into PhieuNhap(MaPN, NgayNhap, MaNXB)" +
                " values('" + txtMaPN.Text.Trim() + "','" + ngaynhap+ "','" + txtMaNXB.Text.Trim() + "')";
                com.CommandText = sql;
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                
                MessageBox.Show("Phiếu Nhâp" + txtMaPN.Text.Trim() + " Được thêm Vào Hệ Thống. Bạn Có Thể Thêm Chi Tiết Phiếu Nhập ở Bên Dưới ", "Thêm TG Thành Công");
                HienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có Lỗi Xảy Ra Vui Lòng Thử lại ");
            }
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
                com.CommandText = "select MaPN,CONVERT(varchar,NgayNhap, 103) as NgayNhap,MaNXB  from PhieuNhap";
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dt.Columns["MaPN"].ColumnName = "Mã Phiếu Nhập";
                dt.Columns["NgayNhap"].ColumnName = "Ngày Nhập";
                dt.Columns["MaNXB"].ColumnName = "Mã Nhà Xuất Bản";
                dataPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataPhieuNhap.DataSource = dt;
            }
            catch (Exception ex) { }

        }
        private void btnDSPN_Click(object sender, EventArgs e)
        {
            kiemtra = 0;
            HienThi();
            toolbox.Visible = true;
            toolbox.Text = "ToolBox Phiếu Nhập";
           
        }

        public void HienThiCTPN()
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "select * ,(SoLuongNhap*GiaNhap) as Tong from ChiTietPhieuNhap";
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dt.Columns["MaPN"].ColumnName = "Mã Phiếu Nhập";
                dt.Columns["MaSach"].ColumnName = "Mã Sách";
                dt.Columns["SoLuongNhap"].ColumnName = "Số Lượng Nhập";
                dt.Columns["GiaNhap"].ColumnName = "Giá Nhập";
                dt.Columns["Tong"].ColumnName = "Tổng Tiền ";
                dataPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataPhieuNhap.DataSource = dt;
            }
            catch (Exception ex) { }
        }
        private void btnCTPN_Click(object sender, EventArgs e)
        {
            HienThiCTPN();
            kiemtra = 1;
            toolbox.Visible = true;
            toolbox.Text = "ToolBox Chi Tiết Phiếu Nhập";
        }

        private void btnAddCTPN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                string sql = "insert into ChiTietPhieuNhap(MaPN, MaSach,SoLuongNhap, GiaNhap)" +
                " values('" + txtMaCTPN.Text.Trim() + "','" + txtMaSach.Text.Trim() + "'," + txtSLN.Text.Trim() + ","+txtGiaNhap.Text.Trim()+")";
                com.CommandText = sql;
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                MessageBox.Show("Phiếu Nhâp CT Được thêm Vào Hệ Thống.  ", "Thêm CT PN Thành Công");
                HienThiCTPN();
           }
            catch (Exception ex)
            {
                MessageBox.Show("Có Lỗi Xảy Ra Vui Lòng Thử lại ");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(kiemtra == 0)
            {
                try
                {
                    String caulenh = "select MaPN,CONVERT(varchar,NgayNhap, 103) as NgayNhap,MaNXB from PhieuNhap where  MaPN='" + txtSearch.Text.ToString().Trim() + "'";
                    SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                    DataTable dt = new DataTable();
                    sqldata.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        dt.Columns["MaPN"].ColumnName = "Mã Phiếu Nhập";
                        dt.Columns["NgayNhap"].ColumnName = "Ngày Nhập";
                        dt.Columns["MaNXB"].ColumnName = "Mã Nhà Xuất Bản";
                        dataPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataPhieuNhap.DataSource = dt;
                    }
                    else { MessageBox.Show("Không Tìm Thấy Dữ Liệu Phiếu Nhập. Vui Lòng kiểm tra lại !"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gặp Lỗi Khi Truy Xuất ! Vui lòng thử lại", "Lỗi Search");
                }
            }
            else if( kiemtra == 1)
            {
                try
                {
                    String caulenh = "select *,(SoLuongNhap*GiaNhap) as Tong from ChiTietPhieuNhap where  MaPN='" + txtSearch.Text.ToString().Trim() + "'";
                    SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                    DataTable dt = new DataTable();
                    sqldata.Fill(dt);
                    if (dt.Rows.Count !=0)
                    {
                        dt.Columns["MaPN"].ColumnName = "Mã Phiếu Nhập";
                        dt.Columns["MaSach"].ColumnName = "Mã Sách";
                        dt.Columns["SoLuongNhap"].ColumnName = "Số Lượng Nhập";
                        dt.Columns["GiaNhap"].ColumnName = "Giá Nhập";
                        dt.Columns["Tong"].ColumnName = "Tổng Tiền ";
                        dataPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataPhieuNhap.DataSource = dt;
                    }
                    else { MessageBox.Show("Không Tìm Thấy Dữ Liệu CT Phiếu Nhập. Vui Lòng kiểm tra lại !"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gặp Lỗi Khi Truy Xuất ! Vui lòng thử lại", "Lỗi Search");
                }
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void dataPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (kiemtra ==  0)
            {
                toolbox.Visible = true;
                toolbox.Text = "ToolBox Phiếu Nhập";
                string ngaytam;
                ngaytam = dataPhieuNhap.Rows[numrow].Cells[1].Value.ToString();
                ngaytam.Trim();
                for(int i = 0; i < ngaytam.Length; i++)
                {
                    if(ngaytam[i]== ' ')
                    {
                         ngaytam =  ngaytam.Substring(0,i);
                    }
                }
                txtMaPN.Text = dataPhieuNhap.Rows[numrow].Cells[0].Value.ToString();
                DateTime date = DateTime.ParseExact(ngaytam, "dd/MM/yyyy", null);
                txtNgayNhap.Value = date;
                txtMaNXB.Text = dataPhieuNhap.Rows[numrow].Cells[2].Value.ToString();

            }else if( kiemtra == 1)
            {
                toolbox.Visible = true;
                toolbox.Text = "ToolBox Chi Tiết Phiếu Nhập";
                txtMaCTPN.Text = dataPhieuNhap.Rows[numrow].Cells[0].Value.ToString();
                txtMaSach.Text = dataPhieuNhap.Rows[numrow].Cells[1].Value.ToString();
                txtSLN.Text = dataPhieuNhap.Rows[numrow].Cells[2].Value.ToString();
                txtGiaNhap.Text = dataPhieuNhap.Rows[numrow].Cells[3].Value.ToString();

            }

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            toolbox.Visible = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(kiemtra == 0)
            {
                try
                {
                    string ngayNhapUpdate = txtNgayNhap.Value.ToString("MM/dd/yyyy").Trim();
                    SqlCommand cmd = ketnoi.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  PhieuNhap set NgayNhap='" + ngayNhapUpdate + "', MaNXB='" + txtMaNXB.Text.ToString().Trim()
                        + "' where MaPN='" + txtMaPN.Text.ToString().Trim() + "'";
                    cmd.ExecuteNonQuery();
                    HienThi();
                    MessageBox.Show("Cập Nhật Thành Công Phiếu Nhập " + txtMaPN.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi Khi Cập Nhật Phiếu Nhập " + txtMaPN.Text);

                }

            }else if( kiemtra == 1)
            {
                try
                {
                    SqlCommand cmd = ketnoi.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  ChiTietPhieuNhap set MaSach ='" + txtMaSach.Text.ToString().Trim() 
                        + "', SoLuongNhap=" + txtSLN.Text.ToString().Trim()+",GiaNhap="+txtGiaNhap.Text.ToString().Trim()
                        + " where MaPN='" + txtMaCTPN.Text.ToString().Trim() + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập Nhật Thành Công Chi Tiết Phiếu Nhập " + txtMaCTPN.Text);
                    HienThiCTPN();
                }catch(Exception ec)
                {
                    MessageBox.Show("Lỗi Khi Cập Nhật Chi Tiết Phiếu Nhập " + txtMaCTPN.Text);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(kiemtra == 0)
            {
                try
                {
                     SqlCommand cmd = ketnoi.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from PhieuNhap where MaPN='" + txtMaPN.Text.Trim() + "'";
                    cmd.ExecuteNonQuery();
                    HienThi();
                    MessageBox.Show("Xóa Thành Công Phiếu Nhập " + txtMaPN.Text);
                    txtMaPN.Clear();
                    txtMaNXB.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Khi Xóa Phiếu Nhập " + txtMaPN.Text);

                }
            }else if(kiemtra == 1)
            {
                try
                {
                    SqlCommand cmd = ketnoi.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from ChiTietPhieuNhap where MaPN='" + txtMaCTPN.Text.Trim() + "'";
                    cmd.ExecuteNonQuery();
                    HienThiCTPN();
                    MessageBox.Show("Xóa Thành Công Chi Tiết  Phiếu Nhập " + txtMaCTPN.Text);
                    txtMaCTPN.Clear();
                    txtMaSach.Clear();
                    txtSLN.Clear();
                    txtGiaNhap.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Khi Xóa  Chi Tiết Phiếu Nhập Phiếu Nhập " + txtMaPN.Text);

                }
            }
        }
    }
}
