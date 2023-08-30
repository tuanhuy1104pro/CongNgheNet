using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001210642_NguyenTranTuanHuy_Buoi3
{
    public class Triangle 
    {
        private int ma;

        public int Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        private int mb;

        public int Mb
        {
            get { return mb; }
            set { mb = value; }
        }
        private int mc;

        public int Mc
        {
            get { return mc; }
            set { mc = value; }
        }
        public Triangle() : this(0,0,0)
        {

        }
        public Triangle(int ma , int mb, int mc)
        {
            
            if(ma < 0 || mb < 0|| mc < 0 || (ma + mb <mc )
            {
                Ma = 0;
                Mb = 0;
                Mc = 0;
            }
        }
       

    }
}
