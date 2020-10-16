using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api_hotel.Model;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Api_hotel.Controllers
{
    [Route("api/Hoteldebois")]
    [ApiController]
    public class OffreController : ControllerBase

    {

        static HttpClient client = new HttpClient();

        public OffreController()
        {
        
            client.BaseAddress = new Uri("http://localhost:51285/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
          new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static List<Reservation> reservation = new List<Reservation>();

        Hotel hotel = new Hotel("Hotel de bois",5, "France", "paris", "16eme arrondissement", 75016);



        [HttpGet("Agence")]
        public ArrayList GetAgences()
     {
         ArrayList listAgences = new ArrayList();
         listAgences.Add(new Agence("agencedevoyage1@gmail.com", "dyhia", 10));
         listAgences.Add(new Agence("agencedevoyage2@gmail.com", "chahinaz", 5));
         return listAgences;
     }

        // dans le cas que c'est un utilisateur normal il peut voir tt les offre d'hotel
        public ArrayList GetOffres()
        {
            ArrayList offres = new ArrayList();
            Offre of1 = new Offre("offre1", 1, DateTime.Parse("01/01/2020"), DateTime.Parse("12/09/2020"), 200);
            Offre of2 =  new Offre("offre2", 2, DateTime.Parse("02/01/2020"), DateTime.Parse("05/09/2020"), 230);
            Offre of3= new Offre("offre3", 4, DateTime.Parse("03/01/2020"), DateTime.Parse("06/09/2020"), 400);
            Offre of4 = new Offre("offre4", 2, DateTime.Parse("04/01/2020"), DateTime.Parse("09/09/2020"), 360);
            Offre of5 = new Offre("offre5", 1, DateTime.Parse("05/01/2020"), DateTime.Parse("10/09/2020"), 100);
            Offre of6 = new Offre("offre6", 3, DateTime.Parse("06/01/2020"), DateTime.Parse("11/09/2020"), 230);
            Offre of7 = new Offre("offre7", 3, DateTime.Parse("07/01/2020"), DateTime.Parse("12/09/2020"), 400);
            Offre of8 = new Offre("offre8", 4, DateTime.Parse("01/06/2020"), DateTime.Parse("10/09/2020"), 360);

            offres.Add(of1);
            offres.Add(of2);
            offres.Add(of3);
            offres.Add(of4);
            offres.Add(of5);
            offres.Add(of6);
            offres.Add(of7);
            offres.Add(of8);
          
            return offres;

        }


  
        [HttpGet("secret")]
            public int CheckAgence(String identAgence, String mdpAgence)
     {
         int b = 0;
         foreach (Agence a in this.GetAgences())
         {
             if (a.Identifiant.Equals(identAgence) && a.Motdepasse.Equals(mdpAgence))
             {
                 b = a.Reduction; break;
             }
         }

         return b;
     }
        //Dans le cas c'est un utilisateur normal qui chercher a voir des offres particulaire
        [HttpGet("{dateDebutReservation}/{dateFinReservation}/{prixMax}/{nombrePersonneHébergés}")]
     public ArrayList GetOffreDisponibile( DateTime dateDebutReservation, DateTime dateFinReservation, int prixMax, int nombrePersonneHébergés)
     {
         ArrayList Offres = new ArrayList();
        
         {
             foreach (Offre o in this.GetOffres())
             {
   
                     int result1 = DateTime.Compare(dateDebutReservation, o.DateDebut);
                     int result2 = DateTime.Compare(dateFinReservation, o.DateFin);
          
                     if (result1 >= 0 && result2 <= 0 && o.Prix <= prixMax && o.NbLits == nombrePersonneHébergés)
                     {
                         Offres.Add(o); break;
                     }
                 
             }

         }
         return Offres;
     }

//pour effectuer une réservation par un utilisateur normal
     [HttpPost ("{idOffre}/{nom}/{prenom}/{numeroCarte}/{dateExpiration}/{code}")]
     public IActionResult Postreservation( String idOffre, String nom, String prenom, long numeroCarte, String dateExpiration, long code)
     {

            var b = "null";

            foreach (Offre o in this.GetOffres())
            {

                if (o.Idoffre.Equals(idOffre))
                {
                    reservation.Add(new Reservation(idOffre, nom, prenom));
                    b = "Votre Réservation d'offre " + idOffre + " est bien effectues sous le nom de " + nom + " prenom " + prenom; break;
                }
                else
                {
                    b = "l'offre n'existe pas ";
                }

            }   

            return Ok(b);

        }

        //pour effectuer une réservation par une Agence
        [HttpPost("{idAgence}/{mdp}/{idOffre}/{nom}/{prenom}/{numeroCarte}/{dateExpiration}/{code}")]
        public async Task< IActionResult> PostreservationParAgence(String idAgence, String mdp, String idOffre, String nom, String prenom, long numeroCarte, String dateExpiration, long code)
        {
            int reduction = this.CheckAgence(idAgence, mdp);
            var b = "null";
               if(reduction >= 0) {
                String path = "api/Agence" + idAgence + "/" + mdp + "/" + idOffre + "/" + nom + "/" + prenom + "/" + numeroCarte + "/" + dateExpiration + "/" + code;

                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {

                    foreach (Offre o in this.GetOffres())
                    {

                        if (o.Idoffre.Equals(idOffre))
                        {
                            reservation.Add(new Reservation(idOffre, nom, prenom));
                            b = "Votre Réservation d'offre " + idOffre + " est bien effectues sous le nom de " + nom + " prenom " + prenom + "avec une reduction de " + reduction; break;
                        }
                        else
                        {
                            b = "l'offre n'existe pas ";
                        }

                    }

                }
          
            }
            return Ok(b);

        }

        //pour S'assur que la reservation est bien effectué
        [HttpGet("Reservation")]
        public List<Reservation> GetReservation()
        {
            return reservation;
        }


        // dans le cas ou l'agence chercher une offre particulaire 
        [HttpGet("{idAgence}/{mdpAgence}/{VilleSjour}/{NbrEtoile}/{dateDebutReservation}/{dateFinReservation}/{prixMax}/{nombrePersonneHébergés}")]
        public async Task<ActionResult<IEnumerable<Offre>>> GetOffres(String idAgence, String mdpAgence, String VilleSjour, int NbrEtoile, DateTime dateDebutReservation, DateTime dateFinReservation, int prixMax, int nombrePersonneHébergés)
        {
            int reduction = this.CheckAgence(idAgence, mdpAgence);

            if (VilleSjour.Equals("paris") && NbrEtoile == 5 && reduction >= 0) { 
            String path = "api/Agence" + idAgence + "/" + mdpAgence + "/" + VilleSjour + "/" + NbrEtoile + "/" + dateDebutReservation + "/" + dateFinReservation + "/" + prixMax + "/" + nombrePersonneHébergés;
         
                HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {

                List<Offre> offres = new List<Offre>();
                offres = await response.Content.ReadAsAsync<List<Offre>>();
                return offres;

            }
           
            else

                return NotFound();
            }else
                return NotFound();
        }


    }
}