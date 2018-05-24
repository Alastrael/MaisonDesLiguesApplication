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
    public partial class DessafecterAdh : MaterialForm
    {
        Connection connexion = new Connection();
        List<Club> listeC;
        List<Adhérents> listeA;
        public DessafecterAdh()
        {
            InitializeComponent();
        }

        private void DessafecterAdh_Load(object sender, EventArgs e)
        {
            listeC = connexion.listeClubs();
            foreach (var item in listeC)
            {
                listBoxClub.Items.Add(item.nom);
            }
        }

        private void listBoxAdh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdh_Click(object sender, EventArgs e)
        {
            int positionC = listBoxClub.SelectedIndex;
            int positionA = listBoxAdh.SelectedIndex;
            Adhérents adh = listeA[positionA]; 
            connexion.desaffectation(adh);
            listBoxAdh.DataSource = null;
            listeA = connexion.listeAdherentsInClub(listeC[positionC]);
            listBoxAdh.Items.Clear();
            foreach (var item in listeA)
            {
                listBoxAdh.Items.Add(item.Nom + " " + item.Prenom);
            }
        }

        private void btnClub_Click(object sender, EventArgs e)
        {
            int positionC = listBoxClub.SelectedIndex;
            listeA = connexion.listeAdherentsInClub(listeC[positionC]);
            listBoxAdh.Enabled = true;
            btnAdh.Enabled = true;
            foreach (var item in listeA)
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
