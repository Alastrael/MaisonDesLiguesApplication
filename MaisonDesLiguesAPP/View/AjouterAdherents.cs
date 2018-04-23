using MaterialSkin;
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

namespace MaisonDesLiguesAPP
{
    public partial class AjouterAdherents : MaterialForm
    {
        private List<Adhérents> liste { get; set; }
        private DataGridView data { get; set; }

        Connection connexion = new Connection();
        public AjouterAdherents(List<Adhérents>liste,DataGridView data)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.liste = liste;
            this.data = data;
        }
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Connection connexion = new Connection();
            Adhérents ajout = new Adhérents(textBoxNOM.Text, textBoxPRENOM.Text
                , dateNaissance.Value, textBoxAdresse.Text, textBoxCP.Text,
                textBoxVille.Text);
            connexion.ajouterAdherent(ajout);

            textBoxNOM.Text = "";
            textBoxPRENOM.Text = "";
            textBoxAdresse.Text = "";
            textBoxCP.Text = "";
            textBoxVille.Text = "";

            data.DataSource = null;
            data.Update();
            data.Refresh();
            data.DataSource = connexion.listeAdherents();
            data.Columns[0].Visible = false;
            data.Columns[3].HeaderText = "Date de Naissance";
            data.Columns[5].HeaderText = "Code Postal";
        }
    }
}
