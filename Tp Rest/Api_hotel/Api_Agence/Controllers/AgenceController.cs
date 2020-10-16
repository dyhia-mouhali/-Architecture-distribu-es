using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections;
using Api_Agence.Model;

namespace Api_Agence.Controllers
{
    [Route("api/AgenceApi")]
    [ApiController]

   
    public class AgenceController : ControllerBase
    {

        public List<String> GetALl()
        {
            return new List<string> { "dyhia", "mouhal"};
        }
      /*  static HttpClient client = new HttpClient();
       
        public AgenceController()
        {
            client.BaseAddress = new Uri("http://localhost:50408/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
          new MediaTypeWithQualityHeaderValue("application/json"));
        }

        

        [HttpGet("{idAgence}/{mdpAgence}/{VilleSjour}/{NbrEtoile}/{dateDebutReservation}/{dateFinReservation}/{prixMax}/{nombrePersonneHébergés}")]
        public async Task<ActionResult<IEnumerable< Offre>>> GetOffres(String idAgence, String mdpAgence, String VilleSjour, int NbrEtoile, DateTime dateDebutReservation, DateTime dateFinReservation, int prixMax, int nombrePersonneHébergés)
        {
            String path = "api/Hoteldebois/" + idAgence + "/" + mdpAgence +"/" + VilleSjour + "/"+NbrEtoile+ "/" + dateDebutReservation + "/" + dateFinReservation + "/" + prixMax + "/" + nombrePersonneHébergés;
           
            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {

                List<Offre> offres = new List<Offre>();
                offres = await response.Content.ReadAsAsync<List<Offre>>();
                return offres;

            }
            else

                return NotFound();
            

        }*/





    }
}