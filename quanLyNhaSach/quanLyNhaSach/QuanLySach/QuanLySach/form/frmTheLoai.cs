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
    public partial class frmTheLoai : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        public frmTheLoai()
        {
            InitializeComponent();
            timer1.Start();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("HH:mm");
            labSecons.Text = DateTime.Now.ToString("ss");
            labday.Text = DateTime.Now.ToString("dddd");
            labDayMonthYear.Text = DateTime.Now.ToString("dd : MM : yyyy");
        }

        private void btnAddTL_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = ketnoi.CreateCommand();
                com.CommandType = CommandType.Text;
                string sql = "insert into TheLoai(MaTL, TenTL)" +
                " values('" + txtMaTL.Text.Trim() + "',N'" + txtTenTL.Text.Trim() + "')";
                com.CommandText = sql;
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                MessageBox.Show("Mã Thể Loại " + txtMaTL.Text.Trim() + " Được thêm Vào Hệ Thống", "Thêm TL Thành Công");
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
                com.CommandText = "select * from TheLoai";
                com.Connection = ketnoi;
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dataTheLoai.DataSource = dt;
            }
            catch (Exception ex) { }

        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            HienThi();
            toolbox.Visible = false;
        }

        private void btnXoaALL_Click(object sender, EventArgs e)
        {
            txtMaTL.Clear();
            txtTenTL.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String caulenh = "select * from TheLoai where MaTL='" + txtSearch.Text.ToString().Trim() + "'";
                SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    //sqldata.Fill(dt);
                    dataTheLoai.DataSource = dt;
                }
                else { MessageBox.Show("Không Tìm Thấy Dữ Liệu. Vui Lòng kiểm tra lại !"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp Lỗi Khi Truy Xuất ! Vui lòng thử lại", "Lỗi Search");
            }
        }

        private void dataTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            toolbox.Visible = true;
            txtMaTL.Text = dataTheLoai.Rows[numrow].Cells[0].Value.ToString();
            txtTenTL.Text = dataTheLoai.Rows[numrow].Cells[1].Value.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update  TheLoai set TenTL=N'" + txtTenTL.Text.Trim() + "' where MaTL='" + txtMaTL.Text.ToString().Trim() + "'";
                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Cập Nhật Thành Công Thể Loại  " + txtMaTL.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Cập Nhật Thể Loại  " + txtMaTL.Text);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = ketnoi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from TheLoai where MaTL='" + txtMaTL.Text.Trim() + "'";
                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Xóa Thành Công Thể Loại  " + txtMaTL.Text);
                txtMaTL.Clear();
                txtTenTL.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Xóa Thể Loại" + txtMaTL.Text);

            }
        }
    }
}
