using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Q1
{
    class Hotel
    {

        private String nom;
        private Adresse adresse;
        private int nombreEtoile;
        private ArrayList chambres = null;

        public String getNom()
        {
            return nom;
        }
        public string Nom { get => nom; set => nom = value; }
        internal Adresse Adresse { get => adresse; set => adresse = value; }
        public int NombreEtoile { get => nombreEtoile; set => nombreEtoile = value; }
        public ArrayList Chambres { get => chambres; set => chambres = value; }

        public Hotel(String nom, Adresse adresse, int nombreEtoile)
        {
            this.Adresse = adresse; this.NombreEtoile = nombreEtoile; this.Chambres = new ArrayList();
            this.Nom = nom;

        }

        public Hotel() { }

        public Boolean addChambre(Chambre chambre)
        {
            if (Chambres.Add(chambre) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
