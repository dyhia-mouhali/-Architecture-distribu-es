using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Adresse
    {

        private String pays;
        private String ville;
        private String rue;
        private int numero;


        public string Pays { get => pays; set => pays = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Rue { get => rue; set => rue = value; }

        public int Numero { get => this.numero; set => this.numero = value; }

        public Adresse(String pays, String ville, String rue, int numero)
        {
            this.pays = pays; this.ville = ville; this.rue = rue; this.numero = numero;

        }

        public Adresse() { }
    }
}

