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

namespace MaisonDesLiguesAPP
{
    public partial class AjouterClub : MetroFramework.Forms.MetroForm
    {
        ClubGerer club;
        DataGridView data;
        List<TypeClub> liste;
        Connection connexion = new Connection();
        public AjouterClub(ClubGerer club/*, DataGridView data*/)
        {
            InitializeComponent();
            this.club = club;
            //this.data = data;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonValiderAjoutClub_Click(object sender, EventArgs e)
        {
            //rajouter une fonction de vérification pour chaque entrée des textbox, si
            //c'est vide ça devrait renvoyer une erreur.
            int positionC = listBoxtype.SelectedIndex;

            Connection connexion = new Connection();
            connexion.ajouterClub(new Club(textBoxNomClub.Text, textBoxLienClub.Text,
                textBoxAdresseClub.Text, textBoxDepartementClub.Text,
                textBoxVilleClub.Text, textboxTel.Text, textBoxEmailClub.Text,
                Convert.ToInt32(liste[positionC].id_type_club)));
            MessageBox.Show("Vous avez créé le club " + textBoxNomClub + ".", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            textBoxNomClub.Text = "";
            textBoxLienClub.Text = "";
            textBoxAdresseClub.Text = "";
            textBoxDepartementClub.Text = "";
            textBoxVilleClub.Text = "";
            textboxTel.Text = "";
            textBoxEmailClub.Text = "";
            //data.DataSource = null;
            //data.Update();
            //data.Refresh();
            //data.DataSource = connexion.listeClubs();
            //data.Columns[0].Visible = false;
            //data.Columns[8].Visible = false;
            //data.Columns[1].HeaderText = "Nom du club";
            //data.Columns[2].HeaderText = "Lien du site du club";
            //data.Columns[3].HeaderText = "Adresse";
            //data.Columns[4].HeaderText = "Code Postal";
            //data.Columns[5].HeaderText = "Ville";
            //data.Columns[6].HeaderText = "Téléphone";
            //data.Columns[7].HeaderText = "Email";  
        }

        private void AjouterClub_Load(object sender, EventArgs e)
        {
            liste = new List<TypeClub>();
            liste = connexion.listeTypeClub();
            foreach (var item in liste)
            {
                listBoxtype.Items.Add(item.libelle);
            }
        }
    }
}
