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
        public AdherentsGerer liste;
        public AffichageAdherents(AdherentsGerer liste)
        {
            InitializeComponent();
            this.liste = liste;
        }

        private void ListerForm_Load(object sender, EventArgs e)
        {
            dataGridLister.AutoGenerateColumns = true;
            dataGridLister.AutoResizeColumns();
            dataGridLister.DataSource = liste.getAdhérents();
        }
    }
}
