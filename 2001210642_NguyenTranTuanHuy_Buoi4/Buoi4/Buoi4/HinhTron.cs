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
        private double Bankinh;

        public double Bankinh1
        {
            get { return Bankinh; }
            set { Bankinh = value; }
        }
        public HinhTron()
        {
            Tam = new ToaDo();
            Bankinh1 = 0;
            Tam.Ten = "Hinh Tron";
        }
        public HinhTron(ToaDo tam, double bkinh)
        {
            Tam = tam;
            Bankinh1 = bkinh;
            Tam.Ten = "Hinh Tron";
        }
        public void TinhChuViTron()
        {
            var temp = 2 * 3.14 * Bankinh1;
            Console.WriteLine("Chu vi hinh tron la: " + temp);
        }
        public void TinhDienTichTron()
        {
            var temp = 3.14 * Bankinh1 * Bankinh1;
            Console.WriteLine("Chu vi hinh tron la: " + temp);
        }
    }
}
