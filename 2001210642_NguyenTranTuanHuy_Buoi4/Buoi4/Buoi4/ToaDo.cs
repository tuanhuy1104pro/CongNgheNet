using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_Module0
{
    class ToaDo
    {
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private float x;

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        private float y;

        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public ToaDo():this(0,0)
        {

        }
        public ToaDo(float x,float y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            
            return "Ten: "+ Ten + "\tToa do x: " + X + " y: " + Y;
        }
    }
}
