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
    public partial class ajouterForm : Form
    {
        public AdherentsGerer liste;
        public ajouterForm(AdherentsGerer liste)
        {
            InitializeComponent();
            this.liste = liste;
        }
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string nom = textBoxNOM.Text;
            string prenom = textBoxPRENOM.Text;
            liste.ajouterAdherent(new Adhérents(nom, prenom, DateTime.Now));
            textBoxNOM.Text = "";
            textBoxPRENOM.Text = "";
        }
    }
}
