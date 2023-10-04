using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenTranTuanHuy_2001210642
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string[] dt = {
                             "Kinh","Hoa","Khac"
                         };
            foreach(var item in dt)
            {
                cbo.Items.Add(item);
            }
        }

        //private void btnDisplay_Click(object sender, EventArgs e)
        //{
        //    string s = "dan toc duoc chon";
        //    if (cbo.SelectedIndex >= 0)
        //        label1.Text = s + cbo.SelectedItem.ToString();
        //    else
        //        label1.Text = "ban chua chon dan toc";
        //}

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

    }
}
