using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api_hotel.Model;
using System.Collections;


using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Api_hotel.Controllers
{
    [Route("api/Image")]
    [ApiController]
    public class ImageController : ControllerBase
    {
     




        static HttpClient client = new HttpClient();

        public ImageController()
        {

            client.BaseAddress = new Uri("http://localhost:51285/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
          new MediaTypeWithQualityHeaderValue("application/json"));
        }



        [HttpGet("Agence")]
        public ArrayList GetAgences()
        {
            ArrayList listAgences = new ArrayList();
            listAgences.Add(new Agence("agencedevoyage1@gmail.com", "dyhia", 10));
            listAgences.Add(new Agence("agencedevoyage2@gmail.com", "chahinaz", 5));
            return listAgences;
        }
        //Afficher une chambre en entrant l id de l'offre
        [HttpGet("Offres")]
        public ArrayList GetOffres()
        {
            ArrayList offres = new ArrayList();
            Offre of1 = new Offre("offre1", 1, DateTime.Parse("01/01/2020"), DateTime.Parse("12/09/2020"), 200);
            Offre of2 = new Offre("offre2", 2, DateTime.Parse("02/01/2020"), DateTime.Parse("05/09/2020"), 230);
            Offre of3 = new Offre("offre3", 4, DateTime.Parse("03/01/2020"), DateTime.Parse("06/09/2020"), 400);
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



        [Route("api/Hotel/{idAgence}/{mdpAgence}")]
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


        // Affiche l'image de l'offre a l'agence 
        [HttpGet("{idAgence}/{mdpAgence}/{dateDebutReservation}/{dateFinReservation}/{prixMax}/{nombrePersonneHébergés}")]
        public async Task<IActionResult> GetImageOffreDisponibile(String idAgence, String mdpAgence, DateTime dateDebutReservation, DateTime dateFinReservation, int prixMax, int nombrePersonneHébergés)
        {
            ArrayList Offres = new ArrayList();
            Byte[] a =null;
            String stringoffre;
            int prixfinal;

            Byte[] b = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\chambre1.jpg");
            Byte[] c = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\chambre_1_per.jpg");
            Byte[] d = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\Chambre2.jpg");
            Byte[] e = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\chambre22.jpg");
            Byte[] f = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\Chambre3pers.jpg");
            Byte[] g = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\chambre-3-personnes.jpg");
            Byte[] h = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\Chambre4.jpg");
            Byte[] l = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\Chambre44.jpg");



            int reduction = this.CheckAgence(idAgence, mdpAgence);
            if (reduction >= 0)
            {
                String path = "api/ImageAgence" + idAgence + "/" + mdpAgence + "/" + dateDebutReservation + "/" + dateFinReservation + "/" + prixMax + "/" + nombrePersonneHébergés;


                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    foreach (Offre o in this.GetOffres())
                    {

                        int result1 = DateTime.Compare(dateDebutReservation, o.DateDebut);
                        int result2 = DateTime.Compare(dateFinReservation, o.DateFin);
                        prixfinal = (o.Prix - o.Prix * reduction / 100);
                        if (result1 >= 0 && result2 <= 0 && o.Prix <= prixMax && o.NbLits == nombrePersonneHébergés)
                        {
                            stringoffre = o.Idoffre;

                            if (stringoffre.Equals("offre1"))
                            {
                                a = b;
                            }
                            else if (stringoffre.Equals("offre5"))
                            {
                                a = c;
                            }
                            else if (stringoffre.Equals("offre2"))
                            {
                                a = e;
                            }
                            else if (stringoffre.Equals("offre4"))
                            {
                                a = d;
                            }
                            else if (stringoffre.Equals("offre6"))
                            {
                                a = f;
                            }
                            else if (stringoffre.Equals("offre7"))
                            {
                                a = g;
                            }
                            else if (stringoffre.Equals("offre8"))
                            {
                                a = l;
                            }
                            else if (stringoffre.Equals("offre3"))
                            {
                                a = h;
                            }
                        }

                    }

                }
            }
            return File(a, "image/jpeg");
        }






        //Affiche l'image pour un utilisateur normale

        [HttpGet("{dateDebutReservation}/{dateFinReservation}/{prixMax}/{nombrePersonneHébergés}")]
        public IActionResult GetOffreDisponibileForUtilisateurNormal( DateTime dateDebutReservation, DateTime dateFinReservation, int prixMax, int nombrePersonneHébergés)
        {
            ArrayList Offres = new ArrayList();
            Byte[] a = null;
            String stringoffre;
         

            Byte[] b = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\chambre1.jpg");
            Byte[] c = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\chambre_1_per.jpg");
            Byte[] d = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\Chambre2.jpg");
            Byte[] e = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\chambre22.jpg");
            Byte[] f = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\Chambre3pers.jpg");
            Byte[] g = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\chambre-3-personnes.jpg");
            Byte[] h = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\Chambre4.jpg");
            Byte[] l = System.IO.File.ReadAllBytes(@"C:\Users\Lenovo\source\repos\Images\Chambre44.jpg");



           
                foreach (Offre o in this.GetOffres())
                {

                    int result1 = DateTime.Compare(dateDebutReservation, o.DateDebut);
                    int result2 = DateTime.Compare(dateFinReservation, o.DateFin);
                    
                    if (result1 >= 0 && result2 <= 0 && o.Prix <= prixMax && o.NbLits == nombrePersonneHébergés)
                    {
                        stringoffre = o.Idoffre;

                        if (stringoffre.Equals("offre1"))
                        {
                            a = b;
                        }
                        else if (stringoffre.Equals("offre5"))
                        {
                            a = c;
                        }
                        else if (stringoffre.Equals("offre2"))
                        {
                            a = e;
                        }
                        else if (stringoffre.Equals("offre4"))
                        {
                            a = d;
                        }
                        else if (stringoffre.Equals("offre6"))
                        {
                            a = f;
                        }
                        else if (stringoffre.Equals("offre7"))
                        {
                            a = g;
                        }
                        else if (stringoffre.Equals("offre8"))
                        {
                            a = l;
                        }
                        else if (stringoffre.Equals("offre3"))
                        {
                            a = h;
                        }
                    }

                }

            
            return File(a, "image/jpeg");
        }




    }
}