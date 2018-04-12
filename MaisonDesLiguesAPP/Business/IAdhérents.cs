using System;

namespace MaisonDesLiguesAPP
{
    public interface IAdhérents
    {
        DateTime DateCreation { get; set; }
        string Nom { get; set; }
        string Prenom { get; set; }
    }
}