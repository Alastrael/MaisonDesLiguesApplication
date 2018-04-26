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
    public partial class ModifierClub : MaterialForm
    {
        Connection connexion = new Connection();
        List<Club> liste;
        List<TypeClub> type;
        Club club;
        DataGridView data;
        public ModifierClub(DataGridView data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void ModifierClub_Load(object sender, EventArgs e)
        {
            liste = connexion.listeClubs();
            type = connexion.listeTypeClub();
            foreach (var item in liste)
            {
                listBox1.Items.Add(item.nom);
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            int positionA = listBox1.SelectedIndex;
            club = liste[positionA];
            textBoxNomClub.Text = club.nom;
            textBoxNomClub.Enabled = true;
            textBoxLienClub.Text = club.lien;
            textBoxLienClub.Enabled = true;
            textboxTel.Text = club.telephone;
            textboxTel.Enabled = true;
            textBoxAdresseClub.Text = club.adresse;
            textBoxAdresseClub.Enabled = true;
            textBoxDepartementClub.Text = club.codepostal;
            textBoxDepartementClub.Enabled = true;
            textBoxVilleClub.Text = club.ville;
            textBoxVilleClub.Enabled = true;
            textBoxEmailClub.Text = club.email;
            textBoxEmailClub.Enabled = true;
            foreach (var item in type)
            {
                listBox2.Items.Add(item.libelle);
            }
            listBox2.Enabled = true;
            btnModifier.Enabled = true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int positionA = listBox2.SelectedIndex;
            club.nom = textBoxNomClub.Text;
            club.lien = textBoxLienClub.Text;
            club.adresse = textBoxAdresseClub.Text;
            club.codepostal = textBoxDepartementClub.Text;
            club.ville = textBoxVilleClub.Text;
            club.telephone = textboxTel.Text;
            club.email = textBoxEmailClub.Text;
            club.idClub = type[positionA].id_type_club;
            connexion.modifierClub(club);

            data.DataSource = null;
            data.Update();
            data.Refresh();
            data.DataSource = connexion.listeClubs();
            data.Columns[0].Visible = false;
            data.Columns[8].Visible = false;
            data.Columns[1].HeaderText = "Nom du club";
            data.Columns[2].HeaderText = "Lien du site du club";
            data.Columns[3].HeaderText = "Adresse";
            data.Columns[4].HeaderText = "Code Postal";
            data.Columns[5].HeaderText = "Ville";
            data.Columns[6].HeaderText = "Téléphone";
            data.Columns[7].HeaderText = "Email";
        }
    }
}
