﻿using MaisonDesLiguesAPP.Business;
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
    public partial class AjouterEvenement : MaterialForm
    {
        Connection connexion = new Connection();
        List<Club> listeClub;
        Evenements even;
        public AjouterEvenement()
        {
            InitializeComponent();
        }

        private void AjouterEvenement_Load(object sender, EventArgs e)
        {
            listeClub = new List<Club>();
            listeClub = connexion.listeClubs();
            foreach (var item in listeClub)
            {
                listBoxclub.Items.Add(item.nom);
            }
        }

        private void btnCréer_Click(object sender, EventArgs e)
        {
            even = new Evenements(maskTitre.Text, dtpDebut.Value, dtpFin.Value);
            int positionC = listBoxclub.SelectedIndex;
            connexion.ajouterEvenement(even, listeClub[positionC]);
            MessageBox.Show("Vous avez créé l'évènement " + maskTitre.Text + ".",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            maskTitre.Text = "";
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
