using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Collections;


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using System.Drawing;

namespace Q2
{
    /// <summary>
    /// Description résumée de MonWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class MonWebService : System.Web.Services.WebService
    {

        ArrayList reservation = new ArrayList();
        ArrayList listHotels = new ArrayList();

        public ArrayList getAgences()
        {
            ArrayList listAgences = new ArrayList();
            listAgences.Add(new Agence("agencedevoyage1@gmail.com", "dyhia", 10));
            listAgences.Add(new Agence("agencedevoyage2@gmail.com", "chahinaz", 5));
            return listAgences;
        }

        public ArrayList getOffres()
        {
            ArrayList offres = new ArrayList();


            return offres;

        }

        public ArrayList getHotels()
        {
            ArrayList listHotels = new ArrayList();
           
            
            Adresse adresseHotel = new Adresse("France", "paris", "16eme arrondissement", 75016);

        
          
            Hotel hotel = new Hotel("Hotel de bois", adresseHotel, 5);

            hotel.addOffre((new Offre("offre1", 2, DateTime.Parse("01/01/2020"), DateTime.Parse("12/09/2020"), 200)));
            hotel.addOffre(new Offre("offre2", 2, DateTime.Parse("02/01/2020"), DateTime.Parse("05/09/2020"), 230));
            hotel.addOffre(new Offre("offre3", 4, DateTime.Parse("03/01/2020"), DateTime.Parse("06/09/2020"), 400));
            hotel.addOffre(new Offre("offre4", 4, DateTime.Parse("04/01/2020"), DateTime.Parse("09/09/2020"), 360));
            hotel.addOffre((new Offre("offre5", 2, DateTime.Parse("05/01/2020"), DateTime.Parse("10/09/2020"), 200)));
            hotel.addOffre(new Offre("offre6", 2, DateTime.Parse("06/01/2020"), DateTime.Parse("11/09/2020"), 230));
            hotel.addOffre(new Offre("offre7", 4, DateTime.Parse("07/01/2020"), DateTime.Parse("12/09/2020"), 400));
            hotel.addOffre(new Offre("offre8", 4, DateTime.Parse("01/06/2020"), DateTime.Parse("10/09/2020"), 360));


            listHotels.Add(hotel); 
            return listHotels;

        }

        public int CheckAgence(String identAgence, String mdpAgence)
        {
            int b = 0;
            foreach (Agence a in this.getAgences())
            {
                if (a.Identifiant.Equals(identAgence) && a.Motdepasse.Equals(mdpAgence))
                {
                    b = a.Reduction; break;
                }
            }

            return b;
        }

        [WebMethod]
        public String Consulterlesdisponibilites(String idAgence, String mdpAgence, DateTime dateDebutReservation,  DateTime dateFinReservation, int prixMax, int nombrePersonneHébergés)
        {
            ArrayList Chambres = new ArrayList();
            String resultatChambre, resultatFinal = "";
            int prixfinal;
            int reduction = this.CheckAgence(idAgence, mdpAgence);
            if (reduction >= 0)
            {

                foreach (Hotel h in this.getHotels())
                {

                        foreach (Offre o in h.Offres)
                        {

                            int result1 = DateTime.Compare(dateDebutReservation, o.DateDebut);
                            int result2 = DateTime.Compare(dateFinReservation, o.DateFin);
                            prixfinal = (o.Prix - o.Prix * reduction / 100);


                            if (result1 >= 0 && result2 <= 0 && o.Prix <= prixMax && o.NbLits == nombrePersonneHébergés)

                            {
                                resultatChambre = "\n \nLe nom de l'hotel est : " + h.Nom + ", \n le nombre d'étoiles est : " + h.NombreEtoile + " + \nl'identifiant de l'offre est : " + o.Idoffre + "\nle nombre de lits est : " + o.NbLits + "  \nla date de début de disponibilité est " +
                                o.DateDebut.ToString() + " \nla date de fin de disponibilité est " + o.DateFin.ToString() + " \nle prix est " + o.Prix + " \nvotre réduction est de : " + reduction;

                                Chambres.Add(resultatChambre);

                            }
                        }
                    
                }
                if (Chambres.Count <= 0)
                {
                    return "vide";
                }
                else
                {
                    foreach (String s in Chambres)
                    {
                        resultatFinal += s;
                    }
                }
            }
            else
            {
                return "erreur";
            }
            return resultatFinal;
        }

        [WebMethod]
        public String Effectuerunereservation(String idAgence, String mdp, String idOffre, String nom, String prenom, long numeroCarte, String dateExpiration, long code)
        {
            String b = "null";
            if (CheckAgence(idAgence, mdp) >= 0)
            {
                foreach (Hotel h in this.getHotels())
                {
                    foreach (Offre o in h.Offres)
                    {
                        if (o.Idoffre.Equals(idOffre))
                        {
                            h.Offres.Remove(o);
                            reservation.Add(new Client(nom, prenom, numeroCarte, dateExpiration, code));
                            b = "une reservation de l'offre"  + idOffre +" sous le nom de " + nom + " prenom " + prenom  ; break;
                        }
                        else {
                            b = "identifiantaux";
                        }
                    }
                }


            }
            else return "erreur";

            return b;
        }

        public ArrayList getReservation()
        {
            return reservation;
        }


   
        }
}
