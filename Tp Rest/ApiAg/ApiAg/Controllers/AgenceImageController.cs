using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    [Route("api/ImageAgence")]
    [ApiController]
    public class AgenceImageController : ControllerBase
    {

        static HttpClient client = new HttpClient();

        public AgenceImageController()
        {
            client.BaseAddress = new Uri("http://localhost:50408/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
          new MediaTypeWithQualityHeaderValue("application/json"));
        }




        [HttpGet("{idAgence}/{mdpAgence}/{VilleSjour}/{NbrEtoile}/{dateDebutReservation}/{dateFinReservation}/{prixMax}/{nombrePersonneHébergés}")]
        public async Task <IActionResult> GetImageOffreDisponibile(String idAgence, String mdpAgence, String VilleSjour, int NbrEtoile, DateTime dateDebutReservation, DateTime dateFinReservation, int prixMax, int nombrePersonneHébergés)
        {
            String path = "api/Image/" + idAgence + "/" + mdpAgence + "/" + VilleSjour + "/" + NbrEtoile + "/" + dateDebutReservation + "/" + dateFinReservation + "/" + prixMax + "/" + nombrePersonneHébergés;

            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {

                Byte[] a = null;
                a = await response.Content.ReadAsByteArrayAsync();
                return File(a, "image/jpeg");

            }
            else

                return NotFound();


        }

    }
}