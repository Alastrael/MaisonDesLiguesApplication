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
        public AjouterClub(ClubGerer club)
        {
            InitializeComponent();
            this.club = club;
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
                textBoxAdresseClub.Text, Convert.ToInt32(textBoxDepartementClub.Text),
                textBoxVilleClub.Text, textBoxTelephoneClub.Text, textBoxEmailClub.Text,
                Convert.ToInt32(textBoxidClub.Text)));
        }
    }
}
