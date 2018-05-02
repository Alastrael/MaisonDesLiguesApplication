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
    public partial class MenuClub : MetroFramework.Forms.MetroForm
    {
        Connection connexion = new Connection();
        List<Club> liste; 
        public MenuClub(List<Club>liste)
        {
            InitializeComponent();
            this.liste = liste;
        }

        private void MenuClub_Load(object sender, EventArgs e)
        {
            dataClubs.AutoGenerateColumns = true;
            dataClubs.AutoResizeColumns();
            dataClubs.DataSource = connexion.listeClubs();
            dataClubs.Columns[0].Visible = false;
            dataClubs.Columns[8].Visible = false;
            dataClubs.Columns[1].HeaderText = "Nom du club";
            dataClubs.Columns[2].HeaderText = "Lien du site du club";
            dataClubs.Columns[3].HeaderText = "Adresse";
            dataClubs.Columns[4].HeaderText = "Code Postal";
            dataClubs.Columns[5].HeaderText = "Ville";
            dataClubs.Columns[6].HeaderText = "Téléphone";
            dataClubs.Columns[7].HeaderText = "Email";
        }

        private void metroCreer_Click(object sender, EventArgs e)
        {
            AjouterClub ajouter = new AjouterClub(liste, dataClubs);
            ajouter.ShowDialog();
        }

        private void metroMod_Click(object sender, EventArgs e)
        {
            ModifierClub modifier = new ModifierClub(dataClubs);
            modifier.ShowDialog();
        }

        private void metroCreer_MouseEnter(object sender, EventArgs e)
        {

        }

        private void metroMenuEvents_Click(object sender, EventArgs e)
        {
            GérerEvents events = new GérerEvents();
            events.ShowDialog();
        }

        private void metroDesaffecter_Click(object sender, EventArgs e)
        {
            DessafecterAdh desafect = new DessafecterAdh();
            desafect.ShowDialog();
        }
    }
}