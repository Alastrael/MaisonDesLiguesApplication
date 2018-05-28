using MaisonDesLiguesAPP.View;
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
    public partial class PagePrincipale : MetroFramework.Forms.MetroForm
    {
        List<Adhérents>liste;
        List<Club> listeClub;
        Connection connexion = new Connection();
        public PagePrincipale()
        {
            InitializeComponent();
            this.liste = new List<Adhérents>();
            this.listeClub = new List<Club>();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        private void PagePrincipale_Load(object sender, EventArgs e)
        {
            //dataAdherents.AutoGenerateColumns = true;
            //dataAdherents.AutoResizeColumns();
            //dataAdherents.DataSource = connexion.listeAdherents();
            //dataAdherents.Columns[0].Visible = false;
            //dataAdherents.Columns[3].HeaderText = "Date de Naissance";
            //dataAdherents.Columns[5].HeaderText = "Code Postal";
            
            //dataClubs.AutoGenerateColumns = true;
            //dataClubs.AutoResizeColumns();
            //dataClubs.DataSource = connexion.listeClubs();
            //dataClubs.Columns[0].Visible = false;
            //dataClubs.Columns[8].Visible = false;
            //dataClubs.Columns[1].HeaderText = "Nom du club";
            //dataClubs.Columns[2].HeaderText = "Lien du site du club";
            //dataClubs.Columns[3].HeaderText = "Adresse";
            //dataClubs.Columns[4].HeaderText = "Code Postal";
            //dataClubs.Columns[5].HeaderText = "Ville";
            //dataClubs.Columns[6].HeaderText = "Téléphone";
            //dataClubs.Columns[7].HeaderText = "Email";
        }

        private void ListerToolTipMenuStrip_Click(object sender, EventArgs e)
        {
            AffichageAdherents Lister = new AffichageAdherents();
            Lister.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void ajouterClub_Click(object sender, EventArgs e)
        {
            /*AjouterClub ajoutClub = new AjouterClub(listeClub/*,dataClubs*///);
            //ajoutClub.ShowDialog();
        }

        private void affecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AffecterAdherent affectation = new AffecterAdherent();
            affectation.ShowDialog();
        }

        private void gérerLesAdhérentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GérerAdhérentsClubs gerer = new GérerAdhérentsClubs();
            gerer.ShowDialog();
        }

        private void gérerLesÉvènementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GérerEvents events = new GérerEvents();
            events.ShowDialog();
        }

        private void metroTileAdh_MouseEnter(object sender, EventArgs e)
        {
            metroTileAdh.Style = MetroFramework.MetroColorStyle.Brown;
        }

        private void metroTileAdh_MouseLeave(object sender, EventArgs e)
        {
            metroTileAdh.Style = MetroFramework.MetroColorStyle.Orange;
        }

        private void metroTileAdh_Click(object sender, EventArgs e)
        {
            liste = connexion.listeAdherents();
            MenuAdhérent menuAdhérent = new MenuAdhérent(liste);
            menuAdhérent.ShowDialog();
        }

        private void metroTileClub_Click(object sender, EventArgs e)
        {
            MenuClub menuclub = new MenuClub(listeClub);
            menuclub.ShowDialog();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
