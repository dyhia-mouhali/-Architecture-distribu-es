using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiAg.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections;

namespace ApiAg.Controllers
{
    [Route("api/Agence")]
    [ApiController]
    public class AgenceController : ControllerBase
    {

        static HttpClient client = new HttpClient();

        public AgenceController()
        {
            client.BaseAddress = new Uri("http://localhost:50408/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
          new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static List<Reservation> reservation = new List<Reservation>();
        //agence regarde la liste des offre particulaire
        [HttpGet("{idAgence}/{mdpAgence}/{VilleSjour}/{NbrEtoile}/{dateDebutReservation}/{dateFinReservation}/{prixMax}/{nombrePersonneHébergés}")]
        public async Task<ActionResult<IEnumerable<Offre>>> GetOffres(String idAgence, String mdpAgence, String VilleSjour, int NbrEtoile, DateTime dateDebutReservation, DateTime dateFinReservation, int prixMax, int nombrePersonneHébergés)
        {
            String path = "api/Hoteldebois/" + idAgence + "/" + mdpAgence + "/" + VilleSjour + "/" + NbrEtoile + "/" + dateDebutReservation + "/" + dateFinReservation + "/" + prixMax + "/" + nombrePersonneHébergés;

            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {

                List<Offre> offres = new List<Offre>();
                offres = await response.Content.ReadAsAsync<List<Offre>>();
                return offres;

            }
            else

                return NotFound();


        }

        //agence fait une reservation
        [HttpPost("{idAgence}/{mdp}/{idOffre}/{nom}/{prenom}/{numeroCarte}/{dateExpiration}/{code}")]
        public async Task<ActionResult> PostreservationParAgence(String idAgence, String mdp, String idOffre, String nom, String prenom, long numeroCarte, String dateExpiration, long code)
        {
            var b = "il y pas eu de connection";
            String pathre = "api/Hoteldebois/" + idAgence + "/" + mdp + "/" + idOffre + "/" + nom + "/" + prenom + "/" + numeroCarte + "/" + dateExpiration + "/" + code;

            HttpResponseMessage response = await client.GetAsync(pathre);

            if (response.IsSuccessStatusCode)
            {


                return Ok(b);

            }
            else

                return NotFound();

        }


    }
      
}