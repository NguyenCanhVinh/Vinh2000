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
    public partial class frmTacGia : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        public frmTacGia()
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

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnAddTG_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                string sql = "insert into TacGia(MaTG, TenTG, LienHe)" +
                " values('" + txtMaTG.Text.Trim() + "',N'" + txtTenTG.Text.Trim() + "',N'" + txtLH.Text.Trim() + "')";
                com.CommandText = sql;
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                MessageBox.Show("Mã Tác giả " + txtMaTG.Text.Trim() + " Được thêm Vào Hệ Thống", "Thêm TG Thành Công");
                HienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có Lỗi Xảy Ra Vui Lòng Thử lại ");
            }
        }

        private void btnXoaALL_Click(object sender, EventArgs e)
        {
            txtMaTG.Clear();
            txtTenTG.Clear();
            txtLH.Clear();
        }

        public void HienThi()
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "select * from TacGia";
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dataTacGia.DataSource = dt;
            }
            catch (Exception ex) { }

        }

        private void txtLienHe_Load(object sender, EventArgs e)
        {
            HienThi();
            toolbox.Visible = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String caulenh = "select * from TacGia where  MaTG='" + txtSearch.Text.ToString().Trim() + "'";
                SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                   
                    dataTacGia.DataSource = dt;
                }
                else { MessageBox.Show("Không Tìm Thấy Dữ Liệu. Vui Lòng kiểm tra lại !"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp Lỗi Khi Truy Xuất ! Vui lòng thử lại", "Lỗi Search");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from TacGia where MaTG ='" + txtMaTG.Text.Trim() + "'";
                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Xóa Thành Tác Giả   " + txtMaTG.Text);
                btnXoaALL.PerformClick();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Xóa Tác Giả" + txtMaTG.Text);

            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update  TacGia set TenTG=N'" + txtTenTG.Text.Trim() + "', LienHe =N'" + txtLH.Text.Trim() + "' where MaTG ='" + txtMaTG.Text.Trim() + "'";

                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Cập Nhật Thành Công Tác Giả " + txtMaTG.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Cập Nhật Tác Giả " + txtMaTG.Text);

            }
        }

        private void dataTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            toolbox.Visible = true;
            txtMaTG.Text = dataTacGia.Rows[numrow].Cells[0].Value.ToString();
            txtTenTG.Text = dataTacGia.Rows[numrow].Cells[1].Value.ToString();
            txtLH.Text = dataTacGia.Rows[numrow].Cells[2].Value.ToString();
        }
    }
}
