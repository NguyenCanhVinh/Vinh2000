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
    public partial class Login : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter sqldata = new SqlDataAdapter();
        public Login()
        {
            InitializeComponent();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
            lenh.Connection = ketnoi;
            this.ActiveControl = username;
            username.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passworld_MouseClick(object sender, MouseEventArgs e)
        {
            passworld.Clear();
        }

        private void username_MouseClick(object sender, MouseEventArgs e)
        {
            username.Clear();
        }

        
        private void signin_Click(object sender, EventArgs e)
        {
            if (username.Text.Trim().Equals("Username") || passworld.Text.Trim().Equals("Passworld")
                || username.Text.Trim().Equals("")|| passworld.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin", "Data Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                String caulenh = "select * from ThuNgan where TenDN='" + username.Text.Trim() + "' and MatKhau='" + passworld.Text.Trim() + "'";
                SqlDataAdapter sqldata = new SqlDataAdapter(caulenh,ketnoi);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                if(dt.Rows.Count ==1)
                {
                    string manv =  dt.Rows[0]["MaNV"].ToString().Trim();
                    Hierarchy hie = new Hierarchy();
                    hie.setH(manv);
                    main mn = new main();
                    mn.maThuNgan = hie.getH();
                    mn.ShowNameThuNgan();
                    this.Hide();
                    mn.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không Thể Đăng Nhập Vui lòng Liên Hệ Quản Lý Hỗ trợ !", "" +
                        "Lost Login!");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

            ScanQrcodes sc = new ScanQrcodes();
            sc.nhan = "login";
            this.Hide();
            
            sc.btnhuybo.Visible = false;
            sc.btnKH.Visible = false;
            sc.ShowDialog();
        }

        private void passworld_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
               // signin.PerformClick();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            username.Focus();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                passworld.Focus();
            }
        }

        private void passworld_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin.PerformClick();
            }
        }
    }
}
