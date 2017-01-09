using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo
{
    class sms : Usluga
    {
        private string numer;
        public void ObliczCene()
        {
            cena=0.15;
        }

        public void ustaw(DateTime a,string b) 
        {
            ustawczas(a);
            this.numer = b;
            ObliczCene();
        }
        public override string ToString()
        {
            return "Sms: numer" + numer + " data i godzina smsa: " + czas + "Laczny koszt: " + cena;
        }
    }
}
