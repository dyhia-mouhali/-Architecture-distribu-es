using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Client
    {
        private String nom;
        private String prenom;
        private int numTel;
        private DateTime dateNaissance;
        private long numeroCarte;
        private DateTime dateExpiration;
        private long code;


        public string Prenom { get => prenom; set => prenom = value; }
     
        public int NumTel { get => numTel; set => numTel = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public long NumeroCarte { get => numeroCarte; set => numeroCarte = value; }
        public DateTime DateExpiration { get => dateExpiration; set => dateExpiration = value; }
        public long Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }

        public Client(string nom, string prenom, int numTel, DateTime dateNaissance , int numeroCarte, DateTime dateExpiration, int code)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.NumTel = numTel;
            this.DateNaissance = dateNaissance;
            this.NumeroCarte = numeroCarte;
            this.DateExpiration = dateExpiration;
            this.Code = code;
        }

        public Client() { }

        public Client (String nom , String prenom, long numeroCarte, DateTime dateExpiration, long code)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }



    }

   


}
