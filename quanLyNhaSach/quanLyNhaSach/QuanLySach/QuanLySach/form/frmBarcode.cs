using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using System.Data.SqlClient;

namespace QuanLySach
{
    public partial class frmBarcode : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter sqldata = new SqlDataAdapter();
        public frmBarcode()
        {
            InitializeComponent();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
            lenh.Connection = ketnoi;
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += Barcode_NewFrame;
            videoCaptureDevice.Start();
        }

        private void Barcode_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                BarcodeReader reader = new BarcodeReader();
            try
            {
                var result = reader.Decode(bitmap);
                if (result != null)
                {
                    textBox1.Invoke(new MethodInvoker(delegate ()
                    {
                        textBox1.Text = "";
                        textBox1.Text = result.ToString().Trim();
                    }));
                }
                pictureBox1.Image = bitmap;
            }catch(Exception exx)
            {
                MessageBox.Show("Không nhận được mã hàng");
            }
                 
            }

        private void frmBarcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }

        private void frmBarcode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                comboBox1.Items.Add(device.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        public delegate void GETDATAMAHANG(string data);
        public GETDATAMAHANG mahang;
        private void btnok_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == null || textBox1.Text.Trim() =="" )
            {
                 MessageBox.Show("Chưa có mã hàng nào được Thêm");
                //textBox1.Visible = false;
            }
            else
            {
                String caulenh = "select * from Sach where MaSach='" + textBox1.Text.Trim()+"'";
                SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    mahang(textBox1.Text.Trim());
                    
                }
                else
                {
                    MessageBox.Show("Không Tìm Thấy Mã Hàng Vui Lòng Thử Lại !", "" +
                        "Lỗi truy xuất!");
                }
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    this.Hide();
                }
            }
        }
    }
}
