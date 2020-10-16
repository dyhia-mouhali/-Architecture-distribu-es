using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1

{
    class Reservation
    {
        public ArrayList reservations = null;
       
       
        public Reservation()
        {
            reservations = new ArrayList();
        }

        public Boolean reserver(Client c )
        {
            if (!reservations.Contains(c))
            {
                reservations.Add(c);
                

                return true;
            }
            else
                return false;
        }

        
    }
}
