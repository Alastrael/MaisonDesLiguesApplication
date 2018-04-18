﻿using MaisonDesLiguesAPP.Business;
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
    public partial class GérerEvents : Form
    {
        List<Club> listeClub;
        List<Evenements> listeEvents;
        Connection connexion = new Connection();
        public GérerEvents()
        {
            InitializeComponent();
        }

        private void GérerEvents_Load(object sender, EventArgs e)
        {
            listeClub = new List<Club>();
            listeClub = connexion.listeClubs();
            foreach (var item in listeClub)
            {
                listBoxClubs.Items.Add(item.nom);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int positionC = listBoxClubs.SelectedIndex;
            listeEvents = connexion.listeEvents(listeClub[positionC]);
            foreach (var item in listeEvents)
            {
                listBoxEvents.Items.Add(item.titre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int positionA = listBoxEvents.SelectedIndex;
            ModifierEvent modifier = new ModifierEvent(listeEvents[positionA]);
            modifier.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int positionA = listBoxEvents.SelectedIndex;
            int positionC = listBoxClubs.SelectedIndex;
            connexion.supprimerEvent(listeEvents[positionA]);
            listeEvents = connexion.listeEvents(listeClub[positionC]);
            for (int i = 0; i < listBoxEvents.Items.Count; i++)
            {
                listBoxEvents.Items.Remove(i);
            }
            listBoxEvents.Items.Clear();
            foreach (var item in listeEvents)
            {
                listBoxEvents.Items.Add(item.titre);
            }
        }

        private void créerUnNouvelÉvènementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterEvenement ajouterEvenement = new AjouterEvenement();
            ajouterEvenement.ShowDialog();
        }
    }
}
