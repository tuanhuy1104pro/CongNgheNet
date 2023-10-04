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
            if (kiemtra(txtR.Text))
            {
                TRR.Nodes.Add(txtR.Text);
                cboR.Items.Add(txtR.Text);
            }
            else
                MessageBox.Show("Phong da ton tai");
            txtR.Text = "";
            txtR.Focus();
        }

        public bool kiemtra(string s)
        {
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach(TreeNode node in TRR.Nodes)
            {
                if(node.Text == cboR.Text)
                {
                    index = node.Index;
                    break;
                }
            }
            TRR.Nodes[index].Nodes.Add(txtName.Text);
            TRR.ExpandAll();
        }
       
    }
}
