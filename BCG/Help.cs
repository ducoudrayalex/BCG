using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCG
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(FlowLayoutPanel1_MouseWheel);
        }
        private void FlowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.Focus();
        }

    }
}