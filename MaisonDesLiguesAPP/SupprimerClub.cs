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
    public partial class SupprimerClub : Form
    {
        Connection connexion = new Connection();
        List<Club> liste = new List<Club>();
        ClubGerer club;
        DataGridView data;
        public SupprimerClub(ClubGerer club, DataGridView data)
        {
            InitializeComponent();
            this.club = club;
            this.data = data;
        }
        private void SupprimerClub_Load(object sender, EventArgs e)
        {
            List<Club> liste = new List<Club>();
            liste = connexion.listeClubs();
            foreach (var item in liste)
            {
                listBoxSupprimerClb.Items.Add(item.nom);
            }
        }
        private void refreshListBox()
        {
            for (int i = 0; i < listBoxSupprimerClb.Items.Count; i++)
            {
                listBoxSupprimerClb.Items.Remove(i);
            }
            listBoxSupprimerClb.Items.Clear();
            foreach (var item in connexion.listeClubs())
            {
                listBoxSupprimerClb.Items.Add(item.nom);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int positionA = listBoxSupprimerClb.SelectedIndex;
            liste = connexion.listeClubs();
            Club clb = liste[positionA];
            connexion.supprimerClub(clb);
            refreshListBox();
            data.DataSource = null;
            data.Update();
            data.Refresh();
            data.DataSource = connexion.listeClubs();
            data.Columns[0].Visible = false;
            data.Columns[8].Visible = false;
            data.Columns[1].HeaderText = "Nom du club";
            data.Columns[2].HeaderText = "Lien du site du club";
            data.Columns[3].HeaderText = "Adresse";
            data.Columns[4].HeaderText = "Code Postal";
            data.Columns[5].HeaderText = "Ville";
            data.Columns[6].HeaderText = "Téléphone";
            data.Columns[7].HeaderText = "Email";
        }
    }
}
