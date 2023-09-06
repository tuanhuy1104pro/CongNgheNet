using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_Module0
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron hinh1 = new HinhTron();
            hinh1.Bankinh1 = 4;
            Console.WriteLine(hinh1.Tam);
            hinh1.TinhChuViTron();
            hinh1.TinhDienTichTron();
            Console.ReadKey();
        }
    }
}
