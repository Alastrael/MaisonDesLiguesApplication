using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisonDesLiguesAPP
{
    public class AdherentsGerer
    {
        private List<Adhérents> liste { get; set; }
        public AdherentsGerer()
        {
            liste = CreationListe.CreerListe();
        }

        public void ajouterAdherent(Adhérents adhérents)
        {
            liste.Add(adhérents);
        }

        public void supprimerAdherent(int i)
        {
            liste.RemoveAt(i);
        }

        public List<Adhérents> getAdhérents()
        {
            return this.liste;
        }
    }
}
