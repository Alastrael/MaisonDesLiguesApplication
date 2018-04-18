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
    public partial class AffichageAdherents : Form
    {
        Connection connexion = new Connection();
        List<Adhérents> adh;
        public AffichageAdherents()
        {
            InitializeComponent();
        }

        private void ListerForm_Load(object sender, EventArgs e)
        {
            adh = connexion.listeAdherents();
            foreach (var item in adh)
            {
                listBoxadh.Items.Add(item.Nom + " " + item.Prenom);
            }
        }
    }
}
