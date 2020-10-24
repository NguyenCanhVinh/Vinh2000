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
    public partial class frmNhaXuatBan : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        public frmNhaXuatBan()
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

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtDT.Clear();
            txtMaNXB.Clear();
            txtTenNXB.Clear();
        }

        private void btnAddNXB_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                string sql = "insert into NhaXuatBan(MaNXB, TenNXB, DiaChiNXB, DienThoai)" +
                " values('" + txtMaNXB.Text.Trim() + "',N'" + txtTenNXB.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "'," + txtDT.Text.Trim() + ")";
                com.CommandText = sql;
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                MessageBox.Show("Mã Nhà Xuất Bản " + txtMaNXB.Text.Trim() + " Được thêm Vào Hệ Thống", "Thêm NXB Thành Công");
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
                com.CommandText = "select * from NhaXuatBan";
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                DataNXBTable.DataSource = dt;
            }
            catch (Exception ex) { }

        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            HienThi();
            toolbox.Visible = false;
        }

        private void DataNXBTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            toolbox.Visible = true;
            txtMaNXB.Text = DataNXBTable.Rows[numrow].Cells[0].Value.ToString();
            txtTenNXB.Text = DataNXBTable.Rows[numrow].Cells[1].Value.ToString();
            txtDiaChi.Text = DataNXBTable.Rows[numrow].Cells[2].Value.ToString();
            txtDT.Text = DataNXBTable.Rows[numrow].Cells[3].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from NhaXuatBan where MaNXB ='" + txtMaNXB.Text.Trim() + "'";
                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Xóa Thành Nhà Xuất Bản  " + txtMaNXB.Text);
                btnXoaAll.PerformClick();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Xóa Nhà Xuất Bản " + txtMaNXB.Text);

            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update  NhaXuatBan set TenNXB=N'" + txtTenNXB.Text.Trim() + "', DiaChiNXB =N'" + txtDiaChi.Text.Trim() + "',DienThoai=" +
                    txtDT.Text.Trim() + "where MaNXB ='" + txtMaNXB.Text.Trim() + "'";

                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Cập Nhật Thành Công Nhà Xuất Bản " + txtMaNXB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Cập Nhật Nhà Xuất Bản " + txtMaNXB.Text);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String caulenh = "select * from NhaXuatBan  where MaNXB ='" + txtSearch.Text.ToString().Trim() + "'";
                SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    //sqldata.Fill(dt);
                    DataNXBTable.DataSource = dt;
                }
                else { MessageBox.Show("Không Tìm Thấy Dữ Liệu. Vui Lòng kiểm tra lại !"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp Lỗi Khi Truy Xuất ! Vui lòng thử lại", "Lỗi Search");
            }
        }
    }
}
