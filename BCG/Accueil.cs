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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            new Aide().Show();
        }

        private void btnPrincipale_Click(object sender, EventArgs e)
        {
            new Principale().Show();
        }
    }
}
