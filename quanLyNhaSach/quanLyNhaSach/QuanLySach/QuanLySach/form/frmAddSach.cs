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
    public partial class frmAddSach : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        public frmAddSach()
        {
            InitializeComponent();
            timer1.Start();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtMaTG.Clear();
            txtNXB.Clear();
            txtSoLuong.Clear();
            txtMaTL.Clear();
            txtDonGia.Clear();
        }

        private void btnAddSach_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                string sql = "insert into  Sach(MaSach,TenSach,MaTG,MaNXB,MaTL,SoLuong,DonGia)" +
                " values('" + txtMaSach.Text.Trim() + "',N'" + txtTenSach.Text.Trim() + "','"
                +txtMaTG.Text.Trim()+"','"+txtNXB.Text.Trim()+"','"+txtMaTL.Text.Trim()+"',"+
                txtSoLuong.Text.Trim()+","+txtDonGia.Text.Trim()+")";
                com.CommandText = sql;
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                MessageBox.Show("1 Sách Được thêm Vào Hệ Thống", "Thêm TL Thành Công");
                HienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có Lỗi Xảy Ra Vui Lòng Thử lại ");
            }
        }
        public void HienThi()
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "select * from Sach";
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dataSachTable.DataSource = dt;
            }
            catch (Exception ex) { }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("HH:mm");
            labSecons.Text = DateTime.Now.ToString("ss");
            labday.Text = DateTime.Now.ToString("dddd");
            labDayMonthYear.Text = DateTime.Now.ToString("dd : MM : yyyy");
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddSach_Load(object sender, EventArgs e)
        {
            HienThi();
            toolbox.Visible = false;
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String caulenh = "select * from Sach where MaSach='" + txtSearch.Text.ToString().Trim() + "'";
                SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    //sqldata.Fill(dt);
                    dataSachTable.DataSource = dt;
                }
                else { MessageBox.Show("Không Tìm Thấy Dữ Liệu. Vui Lòng kiểm tra lại !"); }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gặp Lỗi Khi Truy Xuất ! Vui lòng thử lại", "Lỗi Search");
            }
        }

        private void dataSachTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            toolbox.Visible = true;
            txtMaSach.Text = dataSachTable.Rows[numrow].Cells[0].Value.ToString();
            txtTenSach.Text = dataSachTable.Rows[numrow].Cells[1].Value.ToString();
            txtMaTG.Text = dataSachTable.Rows[numrow].Cells[2].Value.ToString();
            txtNXB.Text = dataSachTable.Rows[numrow].Cells[3].Value.ToString();
            txtMaTL.Text = dataSachTable.Rows[numrow].Cells[4].Value.ToString();
            txtSoLuong.Text = dataSachTable.Rows[numrow].Cells[5].Value.ToString();
            txtDonGia.Text = dataSachTable.Rows[numrow].Cells[6].Value.ToString();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update  Sach set TenSach=N'" + txtTenSach.Text.Trim() + "', MaTG ='" + txtMaTG.Text.Trim() + "',MaNXB='" +
                    txtNXB.Text.Trim() + "',MaTL='" + txtMaTL.Text.Trim() + "',SoLuong=" + txtSoLuong.Text.Trim() + ",DonGia =" + txtDonGia.Text.Trim() + "" +
                    "where MaSach='" + txtMaSach.Text.Trim() + "'";
                   
                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Cập Nhật Thành Công Sách " + txtMaSach.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Cập Nhật Sách " + txtMaSach.Text);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Sach where MaSach ='" + txtMaSach.Text.Trim() + "'";
                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Xóa Thành Công Sách " + txtMaSach.Text);
                btnDeleteAll.PerformClick();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Xóa Sách " + txtMaSach.Text);

            }
        }
    }
}
