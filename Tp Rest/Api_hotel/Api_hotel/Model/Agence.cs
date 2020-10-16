using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Api_hotel.Model
{
    public class Agence
    {
        [Key]
        private string identifiant;
            private string  motdepasse;
        private int reduction;


        public string Identifiant { get => identifiant; set => identifiant = value; }
        public string Motdepasse { get => motdepasse; set => motdepasse = value; }
        public int Reduction { get => reduction; set => reduction = value; }
        public Agence(String identifiant, string motdepasse, int reduction)
        {
            this.identifiant = identifiant;
            this.motdepasse = motdepasse;
            this.reduction = reduction;
        }
        public Agence(String identifiant, int reduction)
        {
            this.identifiant = identifiant;
            this.reduction = reduction;

        }

    }
}
