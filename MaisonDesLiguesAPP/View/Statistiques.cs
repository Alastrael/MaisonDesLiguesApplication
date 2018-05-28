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

            int nbrAd = listeA.Count;

            Adhérents Adhérent;
            List<int> listeD = connexion.CotisationsInClub(club);
            int[] tab = CotisationElevee(club, listeD);
            int CotisationHaute = tab[0];
            int Compteur = tab[1];

            int Total = cotisationTotale(club, listeD);

            Adhérent = listeA[Compteur];

            cotisationElevee.Text = CotisationHaute + " (" + Adhérent.Nom + " " + Adhérent.Prenom+")";
            totalCotisations.Text = Total.ToString();
            nbrAdh.Text = nbrAd.ToString();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int cotisationTotale(Club club, List<int>listeD)
        {
            int CotisationTotale = 0;
            
            foreach (var item in listeD)
            {
                CotisationTotale += item;
            }
            return CotisationTotale;
        }

        public int[] CotisationElevee(Club club, List<int>listeD)
        {
            int[] tab = new int[2];
            int CotisationElevee = 0;
            int Compteur = -1;
            
            foreach (var item in listeD)
            {
                if (item > CotisationElevee)
                {
                    CotisationElevee = item;
                }
            }
            foreach (var item in listeD)
            {
                Compteur++;
                if (item == CotisationElevee)
                {
                    break;
                }
            }
            tab[0] = CotisationElevee;
            tab[1] = Compteur;
            return tab;
        }
    }
}
