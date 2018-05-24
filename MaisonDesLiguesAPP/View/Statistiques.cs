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
    public partial class Statistiques : MaterialForm
    {
        Connection connexion = new Connection();
        List<Club> clubs = new List<Club>();
        public Statistiques()
        {
            InitializeComponent();
        }

        private void Statistiques_Load(object sender, EventArgs e)
        {
            clubs = connexion.listeClubs();
            foreach (var item in clubs)
            {
                listBox1.Items.Add(item.nom);
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            int position = listBox1.SelectedIndex;
            Club club = clubs[position];
            List<Adhérents> listeA = connexion.listeAdherentsInClub(club);

            int cotisationsTotale = 0;
            int nbrAd = listeA.Count;
            int Cot = 0;
            int compteur = -1;
            Adhérents adhCot;

            List<int> listeD = connexion.CotisationsInClub(club);
            foreach (var item in listeD)
            {
                cotisationsTotale += item;
                if (item > Cot)
                {
                    Cot = item;
                }
            }
            foreach (var item in listeD)
            {
                compteur++;
                if (item == Cot)
                {
                    break;
                }
            }
            adhCot = listeA[compteur];
            cotisationElevee.Text = adhCot.Nom + " " + adhCot.Prenom;
            totalCotisations.Text = cotisationsTotale.ToString();
            nbrAdh.Text = nbrAd.ToString();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
