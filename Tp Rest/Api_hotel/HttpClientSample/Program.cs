using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace HttpClientSample
{
    public class Agence
    {
        private string identifiant;
        private int reduction;
        public string Identifiant { get => identifiant; set => identifiant = value; }
        public int Reduction { get => reduction; set => reduction = value; }
    }

    public class Offre
    {
        private String idOffre;
        private int nbLits;
        private DateTime dateDebut;
        private DateTime dateFin;
        private int prix;
        public String Idoffre { get => idOffre; set => idOffre = value; }
        public int NbLits { get => nbLits; set => nbLits = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        public int Prix { get => prix; set => prix = value; }
    }

    class Program
    {
        static HttpClient client = new HttpClient();
        static async Task RunAsync()
        {

            client.BaseAddress = new Uri("http://localhost:50408/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
          new MediaTypeWithQualityHeaderValue("application/json"));
    
        }


        static void Showagence(Agence agence)
        {
            Console.WriteLine($"Name: {agence.Identifiant}\t la reduction est de  " +
                $"{agence.Reduction}");
        }

        static void Showoffre(Offre offre)
        {
            Console.WriteLine($"l'offre : {offre.Idoffre}\t Debut de disponibilié {offre.DateDebut}\t fin de disponibilié  {offre.DateDebut} \t le prix par nuit "+
                $"{offre.Prix}");;
        }

        static async Task GetoffreAsync(string path)
        {
            List<Offre> offres = new List<Offre>();
            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                foreach (Offre of in offres)
                {
                    offres = await response.Content.ReadAsAsync<List<Offre>>();
                    Console.WriteLine("identAgence :{0}\tReduction de :{1}", of.DateDebut, of.DateFin, of.NbLits);
                }
            }else
            {
                Console.WriteLine("NULL");
            }

        }



        static void Main(string[] args)
            {
            // les informations de la recherche 
            String VilleSéjour; DateTime dateArrivée; DateTime dateDepart; 
            int nbrEtoile; int nbrPersonne;
            Console.WriteLine("Veuillez entrer votre choix de ville de séjour   :  ");
            VilleSéjour = Console.ReadLine();
            Console.WriteLine("Veuillez entrer votre date d'arrivée :  ");
            dateArrivée = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer votre date de départ :  ");
            dateDepart = DateTime.Parse(Console.ReadLine());
   
            Console.WriteLine("Veuillez entrer le nombre d'étoile souhaité :  ");
            nbrEtoile = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Veuillez entrer le nombre de personne à héberger :  ");
            nbrPersonne = (int.Parse(Console.ReadLine()));
            Console.ReadKey();

            String path = "api/Hoteldebois/" + dateArrivée + "/" + dateDepart +"/"+ nbrPersonne;
            if (VilleSéjour.Equals("paris") && nbrEtoile >= 5)
            {
                GetoffreAsync(path);
            }



        }







    }


    
}
