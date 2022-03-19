using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            AddButton();
        }
        int i = 0;
         void AddButton()
        {
            Random random = new Random();
           Button btn = new Button() { 
               Text =   i.ToString(),  
               AutoSize = true,
               Location = new Point(random.Next(0,this.Size.Width),random.Next(0,this.Size.Height))
           };
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
            i++;
        }

         void Btn_Click(object sender, EventArgs e)
        {
            Button btn = new Button(); 
            Message.Show(btn.Text);
        }
    }
}
