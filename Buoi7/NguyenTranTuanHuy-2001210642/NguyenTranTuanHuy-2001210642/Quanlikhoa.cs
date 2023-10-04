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
    public partial class Quanlikhoa : Form
    {
        public Quanlikhoa()
        {
            List<string> ds = new List<string>();
            ds.Add("haha");
            ds.Add("hooh");
            ds.Add("hihi");
         
            InitializeComponent();
        }

        private void Quanlikhoa_Load(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            lstRight.Items.Add(lstLeft.SelectedItem);
            lstLeft.Items.Remove(lstLeft.SelectedItem);
        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            lstRight.Items.AddRange(lstLeft.Items);
            lstLeft.Items.Clear();
        }

        private void lstRight_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
    }
}
