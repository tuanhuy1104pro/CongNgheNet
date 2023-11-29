using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace _2001210642_TuanHuy_29_11_2023
{
    public class KetNoi
    {
        public SqlConnection connect;
        public KetNoi()
        {
            connect = new SqlConnection("Data Source=A209PC50\\CSSQL08;Initial Catalog=QLSinhVien;Integrated Security=True");
        }
        public KetNoi(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
        
    }
}
