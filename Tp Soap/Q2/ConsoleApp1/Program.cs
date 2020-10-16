using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using ConsoleApp1.ServiceReference1;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            MonWebServiceSoapClient mons = new MonWebServiceSoapClient();

          
            
           
          
            Console.WriteLine("Veuillez entrer votre identifiant de l'agence :  ");
           String ident = Console.ReadLine();
            Console.WriteLine("Veuillez entrer votre mot de passe :  ");
           String mp = Console.ReadLine();
            Console.WriteLine("Veuillez entrer votre date d'arrivée : mm/jj/aaaa  ");
         String  dateArrivee = Console.ReadLine().Trim();
            Console.WriteLine("Veuillez entrer votre date de depart :mm/jj/aaaa  ");
          String dateDepart = Console.ReadLine().Trim();
            Console.WriteLine("Veuillez entrer votre prix maximum :  ");
            int prix= (int.Parse(Console.ReadLine()));
            Console.WriteLine("Veuillez entrer le nombre de perssonne que vous souhaite heberge :  ");
           int  nbrPersonne = (int.Parse(Console.ReadLine()));
            String r = mons.Consulterlesdisponibilites(ident, mp, DateTime.Parse(dateArrivee), DateTime.Parse(dateDepart),prix,nbrPersonne);

            //String r = mons.Consulterlesdisponibilites(ident, mp,DateTime.Parse( dateArrivee), DateTime.Parse(dateDepart), prix, nbrPersonne);
            if (r.Equals("erreur")) {
                Console.WriteLine("erreur au niveau du mot de passe ou de l'identifiant");
            }
            else
            {
                if (r.Equals("vide"))
                {
                    Console.WriteLine("aucune offret coorespands a vous recherchers");
                }else
                    Console.WriteLine(r);
            }

            Console.WriteLine("si vous souhaite passe a la reservation veuillez entre l'identifiant de l'offre");
            String str= Console.ReadLine().Trim();

            Console.WriteLine("Veuillez entrer votre nom:  ");
            String nom = Console.ReadLine();
            Console.WriteLine("Veuillez entrer votre prenom:  ");
            String prenom = Console.ReadLine();
            Console.WriteLine("Veuillez entrer votre numero de la carte Bancaire:  ");
            long numeroCart = (long.Parse(Console.ReadLine()));
            Console.WriteLine("Veuillez entrer votre dateexpidition sous forme MM/AAAA ");
            String dateExpidition = Console.ReadLine();
            Console.WriteLine("Veuillez entrer votrecode de la carte Bancaire:  ");
            long code = (long.Parse(Console.ReadLine()));
         String reserve=  mons.Effectuerunereservation(ident,mp, str,nom,prenom,numeroCart,dateExpidition,code);


            if (reserve.Equals("erreur"))
            {
                Console.WriteLine("erreur au niveau du mot de passe ou de l'identifiant");
            }
            else
            {
                if (reserve.Equals("identifiantaux"))
                {
                    Console.WriteLine("erruer de l'identifiant");
                }
                else
                    Console.WriteLine(reserve);
            }


        }
    }
}
