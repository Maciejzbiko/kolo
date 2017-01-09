using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo
{
   public abstract class Usluga
    {
        protected DateTime czas;
        protected double cena;
        public void ObliczCone() {}      
        public void ustawczas(DateTime i)
        {
            this.czas = i;
        }   
        
    }  

}
