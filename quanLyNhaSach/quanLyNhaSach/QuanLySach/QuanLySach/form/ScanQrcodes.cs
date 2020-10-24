using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Data.SqlClient;

namespace QuanLySach
{
    public partial class ScanQrcodes : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        public  string nhan;
        public static string gui;
        public ScanQrcodes()
        {
            InitializeComponent();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
           
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void ScanQrcodes_Load(object sender, EventArgs e)
        {
            //textBox1.Text = nhan;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterinfo in filterInfoCollection)
            {
                comboBox1.Items.Add(filterinfo.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void ScanQrcodes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += Video_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }   
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    if(nhan.Equals("main"))
                    {
                        String caulenh = "select TenKH from KhachHang where MaKh='" + result.Text.ToString().Trim() + "'";
                        SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                        DataTable dt = new DataTable();
                        sqldata.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            gui = result.Text.ToString().Trim();
                            textBox1.Text = dt.Rows[0]["TenKH"].ToString();
                            //textBox1.Text = result.Text.ToString().Trim(); 
                            timer1.Stop();
                            if (captureDevice.IsRunning)
                            {
                                captureDevice.Stop();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không Tìm Thấy Mã Khách Hàng Vui Lòng Thử Lại !", "" +
                                "Lỗi truy xuất!");
                            timer1.Stop();
                            if (captureDevice.IsRunning)
                            {
                                captureDevice.Stop();
                            }
                            this.Hide();
                        }
                    }
                    else if(nhan.Equals("login"))
                    {
                        String caulenh = "select * from ThuNgan where MaNV='" + result.Text.ToString().Trim() + "'";
                        SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                        DataTable dt = new DataTable();
                        sqldata.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            //gui = result.Text.ToString().Trim();
                            //textBox1.Text = dt.Rows[0]["TenKH"].ToString();
                            //textBox1.Text = result.Text.ToString().Trim();
                            Hierarchy hie = new Hierarchy();
                            hie.setH(result.Text.ToString().Trim());
                            this.Hide();

                            main mn = new main();
                            mn.maThuNgan = hie.getH();
                            mn.ShowNameThuNgan();

                            timer1.Stop();
                            if (captureDevice.IsRunning)
                            {
                                captureDevice.Stop();
                            }
                            mn.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Không nhận dạng được thẻ");
                            timer1.Stop();
                            if (captureDevice.IsRunning)
                            {
                                captureDevice.Stop();
                            }
                            this.Hide();
                            Login lg = new Login();
                            lg.ShowDialog();

                        }
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                }
                this.Hide();
                Login lg = new Login();
                lg.Show();
            }
            catch(Exception loi) { }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                }
                this.Hide();
              
            }
            catch (Exception loi) { }
        }

        public delegate void GETDATA(string data);
        public GETDATA mydata;

     
        private void btnKH_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == null || textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có Khách Hàng nào được Thêm");
            }
            else
            {
                mydata(gui.Trim());
                
                this.Hide();
            }
        }
    }
 }
