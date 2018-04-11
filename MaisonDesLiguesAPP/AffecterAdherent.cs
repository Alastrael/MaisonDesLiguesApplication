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
    public partial class AffecterAdherent : Form
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

            connexion.affectation(ad, club);
        }
    }
}
