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

namespace MaisonDesLiguesAPP.View
{
    public partial class ModifierEvent : Form
    {
        Evenements even;
        public ModifierEvent(Evenements even)
        {
            this.even = even;
            InitializeComponent();
        }

        private void ModifierEvent_Load(object sender, EventArgs e)
        {
            maskTitre.Text = even.titre;
            dtpDebut.Value = even.debut;
            dtpFin.Value = even.fin;
        }
    }
}
