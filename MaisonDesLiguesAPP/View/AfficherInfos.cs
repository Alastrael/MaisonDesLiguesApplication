using MaisonDesLiguesAPP.Business;
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
    public partial class AfficherInfos : MaterialForm
    {
        Connection connexion = new Connection();
        List<Adhérents> liste;
        Infos infos = new Infos();
        public AfficherInfos()
        {
            InitializeComponent();
        }

        private void AfficherInfos_Load(object sender, EventArgs e)
        {
            liste = connexion.listeAdherents();
            foreach (var item in liste)
            {
                listBoxAdh.Items.Add(item.Nom + " " + item.Prenom);
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            int position = listBoxAdh.SelectedIndex;
            infos.adhInfos(liste[position]);
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
