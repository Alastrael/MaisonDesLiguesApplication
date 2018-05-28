﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisonDesLiguesAPP.Business
{
    public class TypeClub
    {
        public int id_type_club { get; set; }
        public string libelle { get; set; }
        /// <summary>
        /// Constructeur de la classe TypeClub.
        /// </summary>
        /// <param name="libelle"></param>
        public TypeClub(string libelle)
        {
            this.libelle = libelle;
        }
    }
}
