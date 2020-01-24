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
    public partial class frmDuration : Form
    {
        public frmDuration()
        {
            InitializeComponent();
        }

        private void frmDuration_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }
    }
}
