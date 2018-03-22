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
    public partial class supprimer : Form
    {
        AdherentsGerer liste = new AdherentsGerer();
        int index;
        public supprimer(AdherentsGerer liste)
        {
            InitializeComponent();
            this.liste = liste;
        }

        public void suppression(int i)
        {
            liste.supprimerAdherent(i);
        }

        private void buttonSuppression_Click(object sender, EventArgs e)
        {
            suppression(index);
            refreshListBox();
        }

        private void refreshListBox()
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.Items.Remove(i);
            }
            listBox1.Items.Clear();
            foreach (var item in this.liste.getAdhérents())
            {
                listBox1.Items.Add(item.Nom + " " + item.Prenom);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
        }

        private void supprimer_Load(object sender, EventArgs e)
        {
            foreach (var item in this.liste.getAdhérents())
            {
                listBox1.Items.Add(item.Nom+" "+item.Prenom);
            }
        }
    }
}
