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
        public PagePrincipale()
        {
            InitializeComponent();
            this.liste = new AdherentsGerer();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterForm ajouter = new ajouterForm(liste);
            ajouter.ShowDialog();
        }

        private void PagePrincipale_Load(object sender, EventArgs e)
        {
       
        }

        private void ListerToolTipMenuStrip_Click(object sender, EventArgs e)
        {
            ListerForm Lister = new ListerForm(liste);
            Lister.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimer suppression = new supprimer(liste);
            suppression.ShowDialog();
        }

        private void ajouterClub_Click(object sender, EventArgs e)
        {
            clubAjouter ajoutClub = new clubAjouter();
            ajoutClub.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection connexion = new Connection();
            if(connexion.OpenConnection())label1.Text = "mabite";
            
        }
    }
}
