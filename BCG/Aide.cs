using System;
using System.Windows.Forms;

namespace BCG
{
    public partial class Aide : Form
    {
        public Aide()
        {
            InitializeComponent();

            rtbAide.LoadFile("AideBCG.rtf");
        }

        private void rtbPresentation_TextChanged(object sender, EventArgs e)
        {

            rtbAide.LoadFile("../../ressources/AideBCG.rtf");
        }
    }
}
