using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPMS
{
    public partial class frmmain : Form
    {
        private int counter;
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
            counter = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter += 20;
            if (counter <= 100)
            {
                lblDisplay.Text = "Progress... " + counter + "%";
                progressBar1.Value = counter;
                if (counter == 100)
                {

                    frmUser us= new frmUser();
                   us.Visible = true;
                   
                }
            }
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}