using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateTextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            //lbValue.Text=txbValue.Text;
            int num = 0;
            if (Int32.TryParse(txbValue.Text, out num))
                lbValue.Text = (num*num).ToString();    
            else
            {
                lbValue.Text = "vui long nhap lai";
                txbValue.Text = "";
            }
        }

    }
}
