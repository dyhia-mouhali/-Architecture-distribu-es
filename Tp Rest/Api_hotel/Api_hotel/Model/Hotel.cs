using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Api_hotel.Model
{
    public class Hotel
    {

        private string nom;
        private Adresse adresse;
        private int nombreEtoile;

        private String pays;
        private String ville;
        private String rue;
        private int CodePostal;

        public string Pays { get => pays; }
        public string Ville { get => ville; }
        public string Rue { get => rue; }
        public int Code { get => this.CodePostal; }


        private ArrayList offres = new ArrayList();



        public String getNom()
        {
            return nom;
        }




        public string Nom { get => nom; set => nom = value; }
        internal Adresse Adresse { get => adresse; set => adresse = value; }
        public int NombreEtoile { get => nombreEtoile; set => nombreEtoile = value; }
        public ArrayList Offres { get => offres; set => offres = value; }


        public Hotel(String nom,  int nombreEtoile,String pays ,String ville, String rue,int CodePostal)
        {
            this.Nom = nom;
            this.NombreEtoile = nombreEtoile;
            this.offres = new ArrayList();
            this.pays = pays;
            this.ville = ville;
            this.rue = rue;
            this.CodePostal = CodePostal;

        }


        public Hotel() { }


        public Boolean addOffre(Offre chambre)
        {
            if (offres.Add(chambre) >= 0)
            {

                return true;
            }
            else
            {
                return false;
            }

        }


        public ArrayList getOffreHotel(Hotel h)
        {
            ArrayList offresHotel = new ArrayList();
            foreach (Offre o in h.offres)
            {
                offresHotel.Add(o);
            }
            return offresHotel;

        }

    }
}
