using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySach
{
        class Hierarchy
        {
        SqlConnection ketnoi = new SqlConnection();
        public string hierarchy;
        public string cvName;
        public Hierarchy()
        {
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetnoi;
            ketnoi.Open();
        }

        public void setH(string name)
            {
                this.hierarchy = name;
            }

        public string  getH()
            {
                return this.hierarchy;
            }
        public string  getCV(string deca)
            {
                try
                {
                    String caulenh = "select ChucVu from NhanVien where MaNV='" + deca.Trim() + "'";
                    SqlDataAdapter sqldata = new SqlDataAdapter(caulenh, ketnoi);
                    DataTable dt = new DataTable();
                    sqldata.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {

                        this.cvName = dt.Rows[0]["ChucVu"].ToString().Trim();
                    }
                    return cvName;
                }
                catch (Exception ex)
                {
                
                }
                return null;
            }
        
        }
}
