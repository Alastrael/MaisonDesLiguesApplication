using MaisonDesLiguesAPP.Business;
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
    public partial class AffecterAdhEvent : Form
    {
        Club club;
        Evenements even;
        List<Adhérents> liste;
        Connection connexion = new Connection();
        public AffecterAdhEvent(Club club, Evenements even)
        {
            InitializeComponent();
            this.even = even;
            this.club = club;
        }

        private void AffecterAdhEvent_Load(object sender, EventArgs e)
        {
            liste = connexion.listeAdherentsInClub(club);
            foreach (var item in liste)
            {
                listBoxAdh.Items.Add(item.Nom + " " + item.Prenom);
            }
            btnAffecter.Text = "Affecter au club : "+club.nom;
        }

        private void btnAffecter_Click(object sender, EventArgs e)
        {

        }
    }
}
