using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001210642_TuanHuy_29_11_2023
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult r = DialogResult.OK ;
            this.DialogResult = r;
        }
    }
}
