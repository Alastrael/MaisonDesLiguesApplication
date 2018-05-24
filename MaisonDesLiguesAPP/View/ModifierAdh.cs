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
    public partial class ModifierAdh : MaterialForm
    {
        Connection connexion = new Connection();
        List<Adhérents> liste;
        Adhérents adh;
        public ModifierAdh()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifierAdh_Load(object sender, EventArgs e)
        {
            liste = connexion.listeAdherents();
            foreach (var item in liste)
            {
                listBox1.Items.Add(item.Nom + " " + item.Prenom);
            }            
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            int positionA = listBox1.SelectedIndex;
            List<Club> listeC = connexion.listeClubs();
            adh = liste[positionA];
            textBoxNom.Text = adh.Nom;
            textBoxNom.Enabled = true;
            textBoxPrenom.Text = adh.Prenom;
            textBoxPrenom.Enabled = true;
            dtp.Value = adh.Naissance;
            dtp.Enabled = true;
            textBoxAdresse.Text = adh.Adresse;
            textBoxAdresse.Enabled = true;
            textBoxVille.Text = adh.Ville;
            textBoxVille.Enabled = true;
            mskCP.Text = adh.Codepostal;
            mskCP.Enabled = true;
            btnModifier.Enabled = true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            adh.Nom = textBoxNom.Text;
            adh.Prenom = textBoxPrenom.Text;
            adh.Naissance = dtp.Value;
            adh.Adresse = textBoxAdresse.Text;
            adh.Ville = textBoxVille.Text;
            adh.Codepostal = mskCP.Text;
            connexion.modifierAdh(adh);
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
