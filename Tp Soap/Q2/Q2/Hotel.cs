using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace Q2
{
    public class Hotel
    {
        private string nom;
        private Adresse adresse;
        private int nombreEtoile;
      
        private ArrayList offres = new ArrayList();
     


        public String getNom()
        {
            return nom;
        }




        public string Nom { get => nom; set => nom = value; }
        internal Adresse Adresse { get => adresse; set => adresse = value; }
        public int NombreEtoile { get => nombreEtoile; set => nombreEtoile = value; }
        public ArrayList Offres { get => offres; set => offres= value; }
       

        public Hotel(String nom, Adresse adresse, int nombreEtoile)
        {
            this.Adresse = adresse; 
            this.NombreEtoile = nombreEtoile; 
            this.offres = new ArrayList();
            this.Nom = nom;

        }


        public Hotel() { }


        public Boolean addOffre(Offre chambre)
        {
            if (offres.Add(chambre)>=0) {

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
