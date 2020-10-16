using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Q2
{
    public class TypeChambre
    {
        private float prixBase;
        private int nbrLits;

        public TypeChambre(float prixBase, int nbrLits)
        {

            this.PrixBase = prixBase;
            this.NbrLits = nbrLits;
        }

        public float PrixBase { get => prixBase; set => prixBase = value; }
        public int NbrLits { get => nbrLits; set => nbrLits = value; }
    }
}