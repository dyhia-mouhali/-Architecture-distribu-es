using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Chambre
    {
        private TypeChambre typeChambre;
        private DateTime dateDebutDispo;
        private DateTime dateFinDispo;
        private Boolean disponibilité;

        public Chambre(TypeChambre typeChambre, DateTime dateDebutDispo, DateTime dateFinDispo)
        {
            this.TypeChambre = typeChambre;
            this.DateDebutDispo = dateDebutDispo;
            this.DateFinDispo = dateFinDispo;
            int result1 = DateTime.Compare(dateDebutDispo, DateTime.Today);
            int result2 = DateTime.Compare(dateFinDispo, DateTime.Today);
            if (result1 < 0 && result2 > 0)
            {
                this.disponibilité = false;
            }
            else
                this.disponibilité = true;

        }

        public Chambre() { }



        public DateTime DateDebutDispo { get => dateDebutDispo; set => dateDebutDispo = value; }
        public DateTime DateFinDispo { get => dateFinDispo; set => dateFinDispo = value; }
        internal TypeChambre TypeChambre { get => typeChambre; set => typeChambre = value; }
        public bool Disponibilité { get => disponibilité; set => disponibilité = value; }



    }
}
