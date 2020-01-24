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
    public partial class frmVisitor : Form
    {
        public frmVisitor()
        {
            InitializeComponent();
        }

        private void txtVehicle_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmVisitorcs_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
