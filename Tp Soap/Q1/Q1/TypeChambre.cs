using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class TypeChambre
    {


        private Double prixBase;
        private int nbrLits;

        public TypeChambre(double prixBase, int nbrLits)
        {

            this.PrixBase = prixBase;
            this.NbrLits = nbrLits;
        }

        public double PrixBase { get => prixBase; set => prixBase = value; }
        public int NbrLits { get => nbrLits; set => nbrLits = value; }
    }
}

