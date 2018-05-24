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

namespace MaisonDesLiguesAPP.View
{
    public partial class GérerAdhérentsClubs : MaterialForm
    {
        List<Club> listeClub;
        List<Adhérents> listeAdhérents;
        Connection connexion = new Connection();
        public GérerAdhérentsClubs()
        {
            InitializeComponent();
        }

        private void GérerAdhérentsClubs_Load(object sender, EventArgs e)
        {
            listeClub = new List<Club>();
            listeClub = connexion.listeClubs();
            foreach (var item in listeClub)
            {
                listBoxClubs.Items.Add(item.nom);
            }
        }

        private void btnSelectClubs_Click(object sender, EventArgs e)
        {
            int positionA = listBoxClubs.SelectedIndex;
            listeAdhérents = new List<Adhérents>();
            listeAdhérents = connexion.listeAdherentsInClub(listeClub[positionA]);
            foreach (var item in listeAdhérents)
            {
                listBoxAdh.Items.Add(item.Nom + " " + item.Prenom);
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
