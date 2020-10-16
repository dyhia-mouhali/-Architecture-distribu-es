using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAg.Model
{
    public class Offre
    {
        private String idOffre;
        private int nbLits;
        private DateTime dateDebut;
        private DateTime dateFin;
        private int prix;
        public Offre(String idOffre, int nbOfBed, DateTime d1, DateTime d2, int price)
        {
            this.idOffre = idOffre;
            this.nbLits = nbOfBed;
            this.dateDebut = d1;
            this.dateFin = d2;
            this.prix = price;
            int result1 = DateTime.Compare(dateDebut, DateTime.Today);
            int result2 = DateTime.Compare(dateFin, DateTime.Today);


        }
        public String Idoffre { get => idOffre; set => idOffre = value; }
        public int NbLits { get => nbLits; set => nbLits = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        public int Prix { get => prix; set => prix = value; }
    }
}
