using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
           // MonWebServiceSoapClient c = new MonWebServiceSoapClient();
          
            String ident, mp;
            
            int nbrPersonne;
            Console.WriteLine("Veuillez entrer votre identifiant de l'agence :  ");
            ident = Console.ReadLine().Trim();
            Console.WriteLine("Veuillez entrer votre mot de passe :  ");
            mp = Console.ReadLine().Trim();
            Console.WriteLine("Veuillez entrer votre date d'arrivée :  ");

            String dateArrivée = Console.ReadLine();
            DateTime date1 = DateTime.Parse(dateArrivée);
           
            Console.WriteLine("Veuillez entrer votre date de départ :  ");
            String dateDepart = Console.ReadLine();
            DateTime date2 = DateTime.Parse(dateDepart);
        
        
            Console.WriteLine("Veuillez entrer le nombre de perssonne :  ");
            nbrPersonne = (int.Parse(Console.ReadLine()));

        
               if(mp.Equals("motdepasse") && ident.Equals("dyhia"))
            {
               // c.ConsulterDispo(date1, date2, nbrPersonne);
              
            }
        }
    }
}
