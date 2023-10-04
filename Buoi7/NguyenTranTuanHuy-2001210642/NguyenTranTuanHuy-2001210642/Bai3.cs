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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giam doc","To chuc hanh chinh","Ke hoach","Ke toan" };
            foreach(string s in pb)
            {   
                TRR.Nodes.Add(s);
                cboR.Items.Add(s);
            }
            cboR.SelectedIndex = 0;
        }

        private void btnaddR_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
