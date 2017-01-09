using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo
{
    class Internet : Usluga
    {
        private int iloscMB;
        public void ObliczCene()
        {
            cena = iloscMB / 756 % 2;
        }
        public void ustaw(DateTime a, int b)
        {
            ustawczas(a);
            this.iloscMB = b;
            ObliczCene();
            
        }
        public override string ToString()
        {
            return "Internet, data i godzina internetu: " + czas + " iloscMB: " + iloscMB + " Laczny koszt: " + cena;
        }
    }
}
