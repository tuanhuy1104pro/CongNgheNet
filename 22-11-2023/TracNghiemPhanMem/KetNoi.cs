using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TracNghiemPhanMem
{
    public class KetNoi
    {
      
        SqlConnection connection;
        public KetNoi()
        {
            connection = new SqlConnection("Data Source = LAPTOP-A8BQ8SVQ\\SQLEXPRESS;Initial Catalog=CauHoiTracNghiem");
        }
        public KetNoi(string strcn)
        {
            connection = new SqlConnection(strcn);
        }
    }
}
