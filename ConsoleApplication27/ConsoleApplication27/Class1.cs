using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo
{
    class Poloczenie : Usluga
    {
        private string numer;
        private int czasP;
        public void ObliczCene()
        {
            cena = czasP * 0.29;
        }
        public void Kons(DateTime a, string b, int c)
        {
            ustawczas(a);
            this.numer = b;
            this.czasP = c;
            ObliczCene();            
        }
        public override string ToString()
        {
            return "Polaczenie: " + numer + " data i godzina rozmowy: " + czas + " Dlugosc trwania: " + czasP + " Laczny koszt: " + cena;
        }
    

        

    }
}
