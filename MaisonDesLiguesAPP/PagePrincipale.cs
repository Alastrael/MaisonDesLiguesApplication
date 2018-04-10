using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisonDesLiguesAPP
{
    public partial class PagePrincipale : Form
    {
        AdherentsGerer liste;
        ClubGerer listeClub;
        public PagePrincipale()
        {
            InitializeComponent();
            this.liste = new AdherentsGerer();
            this.listeClub = new ClubGerer();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterAdherents ajouter = new AjouterAdherents(liste);
            ajouter.ShowDialog();
        }

        private void PagePrincipale_Load(object sender, EventArgs e)
        {
            /*dataGridLister.AutoGenerateColumns = true;
            dataGridLister.AutoResizeColumns();
            dataGridLister.DataSource = liste.getAdhérents();*/
        }

        private void ListerToolTipMenuStrip_Click(object sender, EventArgs e)
        {
            AffichageAdherents Lister = new AffichageAdherents(liste);
            Lister.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerAdherents suppression = new SupprimerAdherents(liste);
            suppression.ShowDialog();
        }

        private void ajouterClub_Click(object sender, EventArgs e)
        {
            AjouterClub ajoutClub = new AjouterClub(listeClub);
            ajoutClub.ShowDialog();
        }
    }
}
