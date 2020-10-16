using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_hotel.Model
{
    public class Adresse
    {

        private String pays;
        private String ville;
        private String rue;
        private int CodePostal;


        public string Pays { get => pays; }
        public string Ville { get => ville; }
        public string Rue { get => rue; }
        public int Code { get => this.CodePostal; }


        public Adresse(String pays, String ville, String rue, int numero)
        {
            this.pays = pays; this.ville = ville; this.rue = rue; this.CodePostal = numero;

        }

        public Adresse() { }

    }
}
