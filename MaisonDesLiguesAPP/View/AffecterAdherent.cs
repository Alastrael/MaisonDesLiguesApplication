using MaterialSkin.Controls;
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
    public partial class AffecterAdherent : MaterialForm
    {
        Connection connexion = new Connection();
        List<Adhérents> listeAdherent;
        List<Club> listeClub;
        public AffecterAdherent()
        {
            InitializeComponent();
        }

        private void AffecterAdherent_Load(object sender, EventArgs e)
        {
            listeAdherent = new List<Adhérents>();
            listeClub = new List<Club>();
            listeAdherent = connexion.listeAdherentsSansClubs();
            foreach (var item in listeAdherent)
            {
                listBoxAdherents.Items.Add(item.Nom + " " + item.Prenom);
            }
            listeClub = connexion.listeClubs();
            foreach (var item in listeClub)
            {
                listBoxClubs.Items.Add(item.nom);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int positionA = listBoxAdherents.SelectedIndex;
            Adhérents ad = listeAdherent[positionA];

            int positionC = listBoxClubs.SelectedIndex;
            Club club = listeClub[positionC];

            try
            {
                int cotisation = Convert.ToInt32(textBoxCotisation.Text);

                connexion.affectation(ad, club, cotisation);
                ad.idClub = club.id;

                listBoxAdherents.DataSource = null;
                listBoxAdherents.Items.Clear();
                listeAdherent = connexion.listeAdherentsSansClubs();
                foreach (var item in listeAdherent)
                {
                    listBoxAdherents.Items.Add(item.Nom + " " + item.Prenom);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vous avez rentré une mauvaise valeur pour la cotisation. La valeur doit être entière.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
