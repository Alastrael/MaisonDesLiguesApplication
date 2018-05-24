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
    public partial class ModifierEvent : MaterialForm
    {
        Evenements even;
        Connection connexion = new Connection();
        public ModifierEvent(Evenements even)
        {
            this.even = even;
            InitializeComponent();
        }

        private void ModifierEvent_Load(object sender, EventArgs e)
        {
            maskTitre.Text = even.titre;
            dtpDebut.Value = even.debut;
            dtpFin.Value = even.fin;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (maskTitre.Text == "")
            {
                MessageBox.Show("Le champ du Titre ne peut pas être nul.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskTitre.Text = even.titre;
            }
            else if (dtpDebut.Value > dtpFin.Value)
            {
                MessageBox.Show("L'évènement ne peut pas avoir une date de début supérieure à la date de fin.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDebut.Value = even.debut;
                dtpFin.Value = even.fin;
            }
            else
            {
                even.titre = maskTitre.Text;
                even.debut = dtpDebut.Value;
                even.fin = dtpFin.Value;
                connexion.modifierEvent(even);
                MessageBox.Show("Vous avez bien modifié l'évènement : " +
                    even.titre, "Modification Success", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
