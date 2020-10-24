using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySach
{
    class customer
    {
        SqlConnection ketnoi = new SqlConnection();
        
        public customer()
        {
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
        }

        public Boolean GetIDCustomer( string id)
        {

            try
            {
                String caulenh = "select * from KhachHang where MaKh='" + id.Trim() + "'";
                SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    return true;
                }
               
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public Boolean GetIDNV(string id)
        {

            try
            {
                String caulenh = "select * from NhanVien where MaNV='" + id.Trim() + "'";
                SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    return true;
                }

            }
            catch (Exception ex)
            {

            }
            return false;
        }


        public Boolean GetIDNVThuNgan(string id)
        {

            try
            {
                String caulenh = "select * from ThuNgan where MaNV='" + id.Trim() + "'";
                SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    return true;
                }

            }
            catch (Exception ex)
            {

            }
            return false;
        }

    }
}
