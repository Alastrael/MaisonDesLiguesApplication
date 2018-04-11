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
            AjouterAdherents ajouter = new AjouterAdherents(liste, dataGridLister);
            ajouter.ShowDialog();
        }
        private void PagePrincipale_Load(object sender, EventArgs e)
        {
            dataGridClub.AutoGenerateColumns = true;
            dataGridClub.AutoResizeColumns();
            dataGridClub.DataSource = listeClub.getClubs();
            dataGridLister.AutoGenerateColumns = true;
            dataGridLister.AutoResizeColumns();
            dataGridLister.DataSource = liste.getAdhérents();
        }
        private void ListerToolTipMenuStrip_Click(object sender, EventArgs e)
        {
            ListerForm Lister = new ListerForm(liste);
            Lister.ShowDialog();
        }
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerAdherents suppression = new SupprimerAdherents(liste);
            suppression.ShowDialog();
        }
        private void ajouterClub_Click(object sender, EventArgs e)
        {
            AjouterClub ajoutClub = new AjouterClub(listeClub,dataGridClub);
            ajoutClub.ShowDialog();
        }
        //cette fonction a pour but d'actualiser le contenu du datagridview associé
        public static void GenerationDataLister(DataGridView data, AdherentsGerer liste)
        {
            data.DataSource = null;
            data.AutoGenerateColumns = true;
            data.AutoResizeColumns();
            data.DataSource = liste.getAdhérents();
        }
        public static void RefreshDataClubs(DataGridView data, ClubGerer liste)
        {
            data.DataSource = null;
            data.AutoGenerateColumns = true;
            data.AutoResizeColumns();
            data.DataSource = liste.getClubs();
        }
    }
}
