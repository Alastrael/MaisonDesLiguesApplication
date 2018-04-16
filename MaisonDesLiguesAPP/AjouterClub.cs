using System;
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
    public partial class AjouterClub : Form
    {
        ClubGerer club;
        DataGridView data;
        public AjouterClub(ClubGerer club, DataGridView data)
        {
            InitializeComponent();
            this.club = club;
            this.data = data;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonValiderAjoutClub_Click(object sender, EventArgs e)
        {
            //rajouter une fonction de vérification pour chaque entrée des textbox, si
            //c'est vide ça devrait renvoyer une erreur.
            Connection connexion = new Connection();
            connexion.ajouterClub(new Club(textBoxNomClub.Text, textBoxLienClub.Text,
                textBoxAdresseClub.Text, textBoxDepartementClub.Text,
                textBoxVilleClub.Text, textBoxTelephoneClub.Text, textBoxEmailClub.Text,
                Convert.ToInt32(textBoxidClub.Text)));
            textBoxNomClub.Text = "";
            textBoxLienClub.Text = "";
            textBoxAdresseClub.Text = "";
            textBoxDepartementClub.Text = "";
            textBoxVilleClub.Text = "";
            textBoxTelephoneClub.Text = "";
            textBoxEmailClub.Text = "";
            textBoxidClub.Text = "";
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
