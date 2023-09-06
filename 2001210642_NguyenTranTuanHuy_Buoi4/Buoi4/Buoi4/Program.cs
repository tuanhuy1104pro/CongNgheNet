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
            /// This part is for Declare a variable and call
            HinhTron hinh1 = new HinhTron();
            hinh1.Bankinh1 = 4;

            ToaDo x = new ToaDo(5,5);
            HinhTron hinh2 = new HinhTron(x,4);
            
            //////////// Excuted code and run example
            Console.WriteLine(hinh2.Tam);
            hinh2.TinhChuViTron();
            hinh2.TinhDienTichTron();
            Console.ReadKey();
        }
    }
}
