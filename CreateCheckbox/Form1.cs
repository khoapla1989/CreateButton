using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateCheckbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ckbGender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = ckbGender.Checked == true ? "nam" : "nu";
            string showstring = String.Format("Chao ban {0}, ban la {1}", name, gender);
            MessageBox.Show(showstring);    
        }
    }
}
