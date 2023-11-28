namespace TravauxPratiques4
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            affBarOutil.Checked = true;
            toolStripMenuItem2.Checked = true;
            desactBarOutil.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = true;
        }

        private void deplacementsDesDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listes listes = new Listes();
            listes.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Afficher la barre d'outils
            if (toolStrip1.Visible == false)
                toolStrip1.Visible = true;
            affBarOutil.Checked = true;
            toolStripMenuItem2.Checked = true;
            desactBarOutil.Checked = false;
            toolStripMenuItem3.Checked = false;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Cacher la barre d'outils
            if (toolStrip1.Visible == true)
                toolStrip1.Visible = false;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = true;
            affBarOutil.Checked = false;
            desactBarOutil.Checked = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem4.Checked == true)
            {
                toolStripMenuItem4.Checked = false;
                // Cacher le background
                Accueil.ActiveForm.BackgroundImageLayout = ImageLayout.None;
            }
            else
            {
                toolStripMenuItem4.Checked = true;
                // Afficher le background
                Accueil.ActiveForm.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
