using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Q1
{
    class RechercheHotel
    {
        private ArrayList list = null;

        public RechercheHotel()
        {
            this.list = new ArrayList();
        }

        public Boolean add(Hotel hotel)
        {
            if (!list.Contains(hotel))
            {
                list.Add(hotel);
                return true;
            }
            else
                return false;
        }


        public ArrayList rechercherHotel(String villeSéjour, DateTime datedepart, DateTime dateArrivée, Double prixMin, Double prixMax, int nombreEtoile, int nombrePersonne)
        {
            ArrayList hotels = new ArrayList();
            foreach (Hotel h in list)
            {

                if (h.Adresse.Ville.Equals(villeSéjour) && h.NombreEtoile == nombreEtoile)
                {

                    foreach (Chambre c in h.Chambres)
                    {

                        int result1 = DateTime.Compare(dateArrivée, c.DateDebutDispo);
                        int result2 = DateTime.Compare(datedepart, c.DateFinDispo);
                        if (result1 >= 0 && result2 <= 0 && c.TypeChambre.PrixBase <= prixMax && c.TypeChambre.PrixBase >= prixMin && c.TypeChambre.NbrLits == nombrePersonne)

                        {

                            hotels.Add(h); break;
                        }
                    }

                }
            }
            return hotels;
        }


        public ArrayList getHotels()
        {
            return list;
        }



    }
}
