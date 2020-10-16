using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;


namespace Q2
{
    public class Agence
    {
        private string identifiant, motdepasse;
        private int reduction;
        private ArrayList offres = null;
        public string Identifiant { get => identifiant; set => motdepasse = value; }
        public string Motdepasse { get => motdepasse; set => motdepasse = value; }
        public int Reduction { get => reduction; set => reduction = value; }
        public Agence(String identifiant, string motdepasse, int reduction) {
            this.identifiant = identifiant;
            this.motdepasse = motdepasse;
            this.reduction = reduction;
        }

     
        
    }
}