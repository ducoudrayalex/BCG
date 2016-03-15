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
            rtbAccueil.LoadFile("accueilbcg.rtf");
        }

        private void btnLancer_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new Principale().Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuitterAccueil_Click(object sender, EventArgs e)
        {
            new Aide().Show();
        }
    }
}
