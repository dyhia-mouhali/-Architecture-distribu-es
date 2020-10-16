using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_hotel.Model
{
    public class Client
    {


        private String nom;
        private String prenom;
        private long numeroCarte;
        private String dateExpiration;
        private long code;


        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public long NumeroCarte { get => numeroCarte; set => numeroCarte = value; }
        public String DateExpiration { get => dateExpiration; set => dateExpiration = value; }
        public long Code { get => code; set => code = value; }


        public Client(string nom, string prenom, DateTime dateNaissance, int numeroCarte, String dateExpiration, int code)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.NumeroCarte = numeroCarte;
            this.DateExpiration = dateExpiration;
            this.Code = code;
        }

        public Client() { }

        public Client(String nom, String prenom, long numeroCarte, String dateExpiration, long code)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

    }
}
