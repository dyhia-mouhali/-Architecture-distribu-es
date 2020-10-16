using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adresses :
            Adresse adresseHotel1 = new Adresse("France", "montpellier", "6 Rue De La Spirale Languedoc Roussillon", 34000);
            Adresse adresseHotel2 = new Adresse("France", "paris", "12 Cité Bergère", 75009);
            Adresse adresseHotel3 = new Adresse("France", "marseille", "38-40 Quai de Rive Neuve", 13007);


            //Hotels : 
            Hotel hotel1 = new Hotel("Hôtel Mercure", adresseHotel1, 4);
            Hotel hotel2 = new Hotel("Hotel Aston", adresseHotel2, 3);
            Hotel hotel3 = new Hotel("Radisson Blu Hôtel", adresseHotel3, 4);


            TypeChambre typeChambre1 = new TypeChambre(200, 1);
            TypeChambre typeChambre2 = new TypeChambre(300, 2);
            TypeChambre typeChambre3 = new TypeChambre(300, 3);


            //chambres de l'hotel 1 : 
            Chambre Ch1H1 = new Chambre(typeChambre1, DateTime.Parse("01/01/2020"), DateTime.Parse("11/11/2020"));
            Chambre Ch2H1 = new Chambre(typeChambre1, DateTime.Parse("26/04/2020"), DateTime.Parse("30/11/2020"));
            Chambre Ch3H1 = new Chambre(typeChambre1, DateTime.Parse("11/11/2020"), DateTime.Parse("11/12/2020"));
            Chambre Ch4H1 = new Chambre(typeChambre2, DateTime.Parse("02/02/2020"), DateTime.Parse("16/06/2020"));
            Chambre Ch5H1 = new Chambre(typeChambre2, DateTime.Parse("17/06/2020"), DateTime.Parse("20/12/2020"));

            //chambres de l'hotel 2 :
            Chambre Ch1H2 = new Chambre(typeChambre1, DateTime.Parse("27/04/2020"), DateTime.Parse("11/07/2020"));
            Chambre Ch2H2 = new Chambre(typeChambre2, DateTime.Parse("14/03/2020"), DateTime.Parse("12/12/2020"));
            Chambre Ch3H2 = new Chambre(typeChambre3, DateTime.Parse("12/04/2020"), DateTime.Parse("13/05/2020"));

            //chambres de l'hotel 3 :

            Chambre Ch1H3 = new Chambre(typeChambre3, DateTime.Parse("30/03/2020"), DateTime.Parse("25/04/2020"));
            Chambre Ch3h3 = new Chambre(typeChambre3, DateTime.Parse("10/04/2020"), DateTime.Parse("03/09/2020"));
            Chambre CH2H3 = new Chambre(typeChambre2, DateTime.Parse("17/02/2020"), DateTime.Parse("05/05/2020"));


            //Ajout des chambres pour chaque Hotel :


            hotel1.addChambre(Ch1H1);
            hotel1.addChambre(Ch2H1);
            hotel1.addChambre(Ch3H1);
            hotel1.addChambre(Ch4H1); 
            hotel1.addChambre(Ch5H1);
          
          

            hotel2.addChambre(Ch1H2);
            hotel2.addChambre(Ch2H2);
            hotel2.addChambre(Ch3H2);

            hotel3.addChambre(Ch1H3);
            hotel3.addChambre(Ch3h3);
            hotel3.addChambre(CH2H3);
            
                
         



            ArrayList listHotels = new ArrayList();
            RechercheHotel recherche = new RechercheHotel();

            recherche.add(hotel1);
            recherche.add(hotel2);
            recherche.add(hotel3);
           


            Console.ReadKey();

            // les informations de la recherche 
            String VilleSéjour; DateTime dateArrivée; DateTime dateDepart; int prixMin; int prixMax;
            int nbrEtoile; int nbrPersonne;
            Console.WriteLine("Veuillez entrer votre choix de ville  :  ");
            VilleSéjour = Console.ReadLine();
            Console.WriteLine("Veuillez entrer votre date d'arrivée :  ");
            dateArrivée = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer votre date de départ :  ");
            dateDepart = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer votre prix min :  ");
            prixMin = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Veuillez entrer votre prix max :  ");
            prixMax = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Veuillez entrer le nombre d'étoile souhaité :  ");
            nbrEtoile = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Veuillez entrer le nombre de personne à héberger :  ");
            nbrPersonne = (int.Parse(Console.ReadLine()));
            Console.ReadKey();

        

            listHotels = recherche.rechercherHotel(VilleSéjour, dateDepart, dateArrivée, prixMin, prixMax, nbrEtoile, nbrPersonne);
            foreach (Hotel h in listHotels)
            {
                Console.WriteLine("le nom est " + h.Nom);
            }




           



            if (listHotels.Count == 0)

            {
                Console.WriteLine("Aucun de nos hotels ne convients à votre recherche  :( ");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Les hotels qui conviennent à votre recherches sont :  ");

                foreach (Hotel h in listHotels)
                {

                    Console.WriteLine("le nom de l'hotel est  : " + h.Nom);
                    Console.WriteLine("L'adresse de l'hotel est : ");
                    Console.WriteLine("le pays : " + h.Adresse.Pays);
                    Console.WriteLine("la ville  : " + h.Adresse.Ville);
                    Console.WriteLine("la rue  : " + h.Adresse.Rue);
                    Console.WriteLine("le numéro : " + h.Adresse.Numero);

                    foreach (Chambre c in h.Chambres)
                    {
                        Console.WriteLine("le prix de la chambre de nombre de lits : " + c.TypeChambre.NbrLits + " est : " + c.TypeChambre.PrixBase);
                    }

                    Console.WriteLine("le nombre d'étoiles est : " + h.NombreEtoile);
                  

                }
                String nomHotelChoix, nom, prenom;
                long numCarte, code;
                DateTime dateExpiration;
                Reservation reservation = new Reservation();
                Console.WriteLine("entrer le nom de l'hotel de votre choix' : ");
                nomHotelChoix = Console.ReadLine();
                if (!nomHotelChoix.Equals("quit"))
                {

                    Console.WriteLine("veuillez entrer votre nom ");
                    nom = Console.ReadLine();
                    Console.WriteLine("veuillez entrer votre prénom ");
                    prenom = Console.ReadLine();
                    Console.WriteLine(" accedez au paiement veuillez  entrer les informations de votre carte de crédit :");
                    Console.WriteLine("Numéro de Carte :  ");
                    numCarte = (Convert.ToInt64(Console.ReadLine()));
                    Console.WriteLine("Date d'expiration :  ");
                    dateExpiration = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Code :  ");
                    code = (Convert.ToInt64(Console.ReadLine()));

                    Client c = new Client(nom, prenom, numCarte, dateExpiration, code);
                    if (reservation.reserver(c))
                    {
                        Console.WriteLine("Votre réservation a bien été effectué, nous vous souhaite la biennevenue Merci ! ");
                    }
                    else
                    {
                        Console.WriteLine("echec de réservation :(   ");

                    }


                }

            }
        
            Console.ReadKey();



        }

    }
    
    
}
