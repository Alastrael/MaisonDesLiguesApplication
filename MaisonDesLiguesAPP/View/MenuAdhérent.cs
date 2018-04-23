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
    public partial class MenuAdhérent : MetroFramework.Forms.MetroForm
    {
        Connection connexion = new Connection();
        List<Adhérents> liste;
        public MenuAdhérent(List<Adhérents>liste)
        {
            InitializeComponent();
            this.liste = liste;
        }

        private void MenuAdhérent_Load(object sender, EventArgs e)
        {
            dataAdherent.AutoGenerateColumns = true;
            dataAdherent.AutoResizeColumns();
            dataAdherent.DataSource = connexion.listeAdherents();
            dataAdherent.Columns[0].Visible = false;
            dataAdherent.Columns[3].HeaderText = "Date de Naissance";
            dataAdherent.Columns[5].HeaderText = "Code Postal";
        }

        private void metroTileCreer_Click(object sender, EventArgs e)
        {
            AjouterAdherents ajouter = new AjouterAdherents(liste, dataAdherent);
            ajouter.ShowDialog();
        }

        private void metroTileCreer_MouseEnter(object sender, EventArgs e)
        {
            metroTileCreer.Style = MetroFramework.MetroColorStyle.Brown;
        }

        private void metroTileCreer_MouseLeave(object sender, EventArgs e)
        {
            metroTileCreer.Style = MetroFramework.MetroColorStyle.Orange;
        }

        private void metroTileModifier_Click(object sender, EventArgs e)
        {
            ModifierAdh modifier = new ModifierAdh();
            modifier.ShowDialog();
        }

        private void metroTileAffecter_Click(object sender, EventArgs e)
        {
            AffecterAdherent affecter = new AffecterAdherent();
            affecter.ShowDialog();
        }
        private void metroTileAffecter_MouseEnter(object sender, EventArgs e)
        {
            metroTileAffecter.Style = MetroFramework.MetroColorStyle.Brown;
        }
        private void metroTileAffecter_MouseLeave(object sender, EventArgs e)
        {
            metroTileAffecter.Style = MetroFramework.MetroColorStyle.Orange;
        }

        private void metroTileSupprimer_Click(object sender, EventArgs e)
        {
            SupprimerAdherents supprimer = new SupprimerAdherents(dataAdherent);
            supprimer.ShowDialog();
        }

        private void metroTileSupprimer_MouseEnter(object sender, EventArgs e)
        {
            metroTileSupprimer.Style = MetroFramework.MetroColorStyle.Pink;
        }

        private void metroTileSupprimer_MouseLeave(object sender, EventArgs e)
        {
            metroTileSupprimer.Style = MetroFramework.MetroColorStyle.Red;
        }
    }
}
