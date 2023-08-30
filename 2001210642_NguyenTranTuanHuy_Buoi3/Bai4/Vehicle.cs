using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
     public class Vehicle
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string Tag;

        public string Tag1
        {
            get { return Tag; }
            set { Tag = value; }
        }
        private int CC;

        public int CC1
        {
            get { return CC; }
            set { CC = value; }
        }
        private float giatri;

        public float Giatri
        {
            get { return giatri; }
            set { giatri = value; }
        }

        private float thue;

        public float Thue
        {
            get { return thue; }
            set {
                if (value > 0)
                    thue = value;
            }
        }
         
        public float tinhThue()
        {
            if (CC1 < 100)
                thue = (float)(giatri * 1) / 100;

            else
            {
                if(CC1 <= 200)
                    thue = (float)(giatri * 3) / 100;
                else
                {
                    thue = (float)(giatri * 5) / 100;
                }
            }

            return thue;
        }
        public Vehicle(string name, string tag,int cc,float giatri)
        {
            this.name = name;
            this.Tag = tag;
            this.CC = cc;
            this.giatri = giatri;
            this.thue = tinhThue();
        }
         public void tostring()
        {
            Console.WriteLine("TenChuxe\t\tLoaixe\t\tDungtich\t\tTrigia\t\tThue");
            Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}",name,Tag,CC,giatri,thue);
        }
    }
}
