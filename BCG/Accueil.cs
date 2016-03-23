using System;
using System.Windows.Forms;

namespace BCG
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            try
            {
                InitializeComponent();
                this.CenterToScreen();
                rtbAccueil.LoadFile("../../ressources/accueilbcg.rtf");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLancer_Click(object sender, EventArgs e)
        {
            this.Hide();
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
