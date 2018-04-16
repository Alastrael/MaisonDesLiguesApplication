using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisonDesLiguesAPP.Business
{
    public class Evenements
    {
        public int id { get; set; }
        public string titre { get; set; }
        public DateTime debut { get; set; }
        public DateTime fin { get; set; }

        public Evenements(string titre, DateTime debut, DateTime fin)
        {
            this.titre = titre;
            this.debut = debut;
            this.fin = fin;
        }
    }
}
