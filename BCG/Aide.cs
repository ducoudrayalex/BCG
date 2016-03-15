using System.Windows.Forms;

namespace BCG
{
    public partial class Aide : Form
    {
        public Aide()
        {
            InitializeComponent();
            rtbAide.LoadFile("../../ressources/AideBCG.rtf");
        }
    }
}
