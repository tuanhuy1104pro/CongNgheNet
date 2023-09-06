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
            ToaDo x = new ToaDo(5,5);
            HinhTron hinh2 = new HinhTron(x,10.5);
            
            //////////// Excuted code and run example
            hinh2.ToString();
            Console.ReadKey();
        }
    }
}
