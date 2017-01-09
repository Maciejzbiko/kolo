using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo
{
    interface IDodaj
    {
        void DodajPoloczenie(string numer, int czasP);
        void DodajSms(string numer);
        void DodajInternet(int iloscMB);
    }
}
