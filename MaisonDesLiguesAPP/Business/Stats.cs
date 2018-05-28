using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisonDesLiguesAPP.Business
{
    public class Stats
    {
        //Cette classe sert à faire des statistiques pour les clubs.

        /// <summary>
        /// Cette méthode retourne les cotisations totales d'un club en les additionnant une par une grâce à une liste de Int.
        /// </summary>
        /// <param name="club"></param>
        /// <param name="listeD"></param>
        /// <returns></returns>
        public int cotisationTotale(Club club, List<int> listeD)
        {
            int CotisationTotale = 0;

            foreach (var item in listeD)
            {
                CotisationTotale += item;
            }
            return CotisationTotale;
        }
        /// <summary>
        /// Cette méthode retourne la cotisation la plus élevée ainsi que le compteur pour retrouver la personne qui a effectué cette cotisation.
        /// </summary>
        /// <param name="club"></param>
        /// <param name="listeD"></param>
        /// <returns></returns>
        public int[] CotisationElevee(Club club, List<int> listeD)
        {
            int[] tab = new int[2];
            int CotisationElevee = 0;
            int Compteur = -1;

            foreach (var item in listeD)
            {
                if (item > CotisationElevee)
                {
                    CotisationElevee = item;
                }
            }
            foreach (var item in listeD)
            {
                Compteur++;
                if (item == CotisationElevee)
                {
                    break;
                }
            }
            tab[0] = CotisationElevee;
            tab[1] = Compteur;
            return tab;
        }
    }
}
