﻿using System;
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
    public partial class AjouterAdherents : Form
    {
        public AdherentsGerer liste;
        public DataGridView data;

        Connection connexion = new Connection();
        public AjouterAdherents(AdherentsGerer liste,DataGridView data)
        {
            InitializeComponent();
            this.liste = liste;
            this.data = data;
        }
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Connection connexion = new Connection();
            Adhérents ajout = new Adhérents(textBoxNOM.Text, textBoxPRENOM.Text
                , dateNaissance.Value, textBoxAdresse.Text, textBoxCP.Text,
                textBoxVille.Text);
            connexion.ajouterAdherent(ajout);

            textBoxNOM.Text = "";
            textBoxPRENOM.Text = "";
            textBoxAdresse.Text = "";
            textBoxCP.Text = "";
            textBoxVille.Text = "";

            data.DataSource = null;
            data.Update();
            data.Refresh();
            data.DataSource = connexion.listeAdherents();
        }
    }
}
