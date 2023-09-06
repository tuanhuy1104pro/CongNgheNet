using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_Module0
{
    class HinhTron
    {
        private ToaDo tam;

        public ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }
        private double bankinh;

        public double Bankinh
        {
            get { return bankinh; }
            set { bankinh = value; }
        }
        public HinhTron()
        {
            Tam = new ToaDo();
            bankinh = 0;
            Tam.Ten = "Hinh Tron";
        }
        public HinhTron(ToaDo tam, double bkinh)
        {
            Tam = tam;
            bankinh = bkinh;
            Tam.Ten = "Hinh Tron";
        }
        public void TinhChuViTron()
        {
            var temp = 2 * 3.14 * bankinh;
            Console.WriteLine("\nChu vi hinh tron la: " + temp);
        }
        public void TinhDienTichTron()
        {
            var temp = 3.14 * bankinh * bankinh;
            Console.WriteLine("\nDien tich hinh tron la: " + temp);
        }
        public void ToString()
        {
            Console.Write(Tam + "Co ban kinh " + bankinh);
            TinhChuViTron();
            TinhDienTichTron();
        }
    }
}
