using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisonDesLiguesAPP
{
    class CreationListeClub
    {
        public CreationListeClub()
        {

        }

        public static List<Adhérents> CreerListeClub()
        {
            List<Adhérents> creerListe = new List<Adhérents>();
            creerListe.Add(new Adhérents("MARTIN", "Michael", DateTime.Now));
            return creerListe;
        }
    }
}
