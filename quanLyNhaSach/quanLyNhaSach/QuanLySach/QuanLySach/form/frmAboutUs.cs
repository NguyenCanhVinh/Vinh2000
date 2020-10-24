using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.form
{
    public partial class frmAboutUs : Form
    {
        public frmAboutUs()
        {
            InitializeComponent();
            timer1.Start();
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

        private void frmAboutUs_Load(object sender, EventArgs e)
        {
            
            //titleNhaSach.Location = new Point(884, 560);
           timer2.Start();
            timer3.Start();
        }
        int x;
        private void timer2_Tick(object sender, EventArgs e)
        {
            x = titleNhaSach.Location.X;
            x--;
            titleNhaSach.Location = new Point(x, titleNhaSach.Location.Y);
            if( x == 0)
            {
                timer2.Stop();
            }
        }

        int k;
        private void timer3_Tick(object sender, EventArgs e)
        {
            k= text.Location.Y;
            k--;
            text.Location = new Point( text.Location.X, k);
            if (k == 100)
            {
                timer3.Stop();
            }
        }
    }
}
