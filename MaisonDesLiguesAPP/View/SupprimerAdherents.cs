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
    public partial class SupprimerAdherents : Form
    {
        Connection connexion = new Connection();
        List<Adhérents> liste;
        DataGridView data;
        public SupprimerAdherents(DataGridView data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void buttonSuppression_Click(object sender, EventArgs e)
        {
            int positionA = listBoxSupprimerAdh.SelectedIndex;
            liste = connexion.listeAdherents();
            Adhérents ad = liste[positionA];
            connexion.supprimerAdherent(ad);
            refreshListBox();

            data.DataSource = null;
            data.Update();
            data.Refresh();
            data.DataSource = connexion.listeAdherents();
            data.Columns[0].Visible = false;
            data.Columns[3].HeaderText = "Date de Naissance";
            data.Columns[5].HeaderText = "Code Postal";
        }

        private void refreshListBox()
        {
            for (int i = 0; i < listBoxSupprimerAdh.Items.Count; i++)
            {
                listBoxSupprimerAdh.Items.Remove(i);
            }
            listBoxSupprimerAdh.Items.Clear();
            foreach (var item in connexion.listeAdherents())
            {
                listBoxSupprimerAdh.Items.Add(item.Nom + " " + item.Prenom);
            }
        }
        private void supprimer_Load(object sender, EventArgs e)
        {
            List<Adhérents> liste = new List<Adhérents>();
            liste = connexion.listeAdherents();
            foreach (var item in liste)
            {
                listBoxSupprimerAdh.Items.Add(item.Nom+" "+item.Prenom);
            }
        }
    }
}
