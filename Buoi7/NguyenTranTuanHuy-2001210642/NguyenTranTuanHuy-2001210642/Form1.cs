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
    public partial class Form1 : Form
    {
        List<Doituong> ds = new List<Doituong>();
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Doituong dt = new Doituong();
            dt.Name = txtGiatri.Text;
            
            ds.Add(dt);
            MessageBox.Show("Them doi tuong vao thanh cong");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach(var dt in ds)
            {
                if(txtGiatri.Text == dt.Name)
                {
                    MessageBox.Show("Da tim thay doi tuong trong danh sach\n Ten: " + txtGiatri.Text);
                    return;
                }
                
            }
                    MessageBox.Show("Invalid Name");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
