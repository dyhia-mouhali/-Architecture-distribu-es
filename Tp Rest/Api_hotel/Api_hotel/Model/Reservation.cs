using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_hotel.Model
{
    public class Reservation
    {
        String idOffrereserve;
        String nomAgence;
        String nomClient, prenomClient;

        public String Idoffrereserve { get => idOffrereserve; set => idOffrereserve = value; }
        public String NomAgence { get => nomAgence; set => nomAgence = value; }
        public String NomClient { get => nomClient; set => nomClient = value; }
        public String PrenomClient { get => prenomClient; set => prenomClient = value; }

        public Reservation(String idoffrereserve, String nomAgence, String nomClient, String prenomClient) {

            this.idOffrereserve = idoffrereserve;
            this.nomAgence = nomAgence;
            this.nomClient = nomClient;
            this.prenomClient = prenomClient;
                }
        public Reservation(String idoffrereserve,  String nomClient, String prenomClient)
        {

            this.idOffrereserve = idoffrereserve;
           
            this.nomClient = nomClient;
            this.prenomClient = prenomClient;
        }

    }
}
