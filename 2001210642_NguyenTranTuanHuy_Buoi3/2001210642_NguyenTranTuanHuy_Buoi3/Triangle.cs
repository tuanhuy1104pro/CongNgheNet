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
            set {
                if (value > 0)
                    ma = value; 
            }
        }
        private int mb;

        public int Mb
        {
            get { return mb; }
            set
            {
                if (value > 0)
                    mb = value;
            }
        }
        private int mc;

        public int Mc
        {
            get { return mc; }
            set
            {
                if (value > 0)
                    mc = value;
            }
        }
        public Triangle() : this(0,0,0)
        {

        }
        public Triangle(int ma , int mb, int mc)
        {

            if (ma < 0 || mb < 0 || mc < 0 || (ma + mb < mc) || (mb + mc < ma) || (ma + mc < mb))
            {
                Ma = 0;
                Mb = 0;
                Mc = 0;
                Console.WriteLine("inavalid of Triangle. So defaul 3 sides are 0");
            }
            else
            {
                Ma = ma;
                Mb = mb;
                Mc = mc;
            }
        }
       
        public int tinhChuVi ()
        {
            return  Ma + Mb + Mc;
        }
        public double tinhDienTich()
        {
            double nuaChuVi = (double)tinhChuVi()/ 2;
            double dientich = Math.Sqrt(nuaChuVi * (nuaChuVi - Ma) * (nuaChuVi - Mb) * (nuaChuVi - Mc));
            return dientich;
        }
        public void DefineTriangle()
        {
            if((Ma + Mb < Mc) || (Mb + Mc < Ma) || (Ma + Mc < Mb))
            {
                Console.WriteLine("Khong phai tam giac");
            }
            else
            {
                if(Ma == Mb && Mb == Mc && Ma == Mc)
                    Console.WriteLine("Tam giac Deu");
                else
                {
                    if(Ma == Mb || Ma == Mc || Mc == Mb)
                        Console.WriteLine("Tam giac can");
                    else
                    {
                        Console.WriteLine("Tam giac thuong");
                    }
                }


            }
        }
        public void ToString()
        {
            Console.WriteLine ("Chi so ba canh lan luot la " + Ma + " " + Mb + " " + Mc);
            Console.Write("Kieu tam giac: ");
            DefineTriangle();
            Console.WriteLine(" Chu vi: " + tinhChuVi() + " Dien tich: " + tinhDienTich()); 
        }
    }
}
