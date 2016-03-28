using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak17
{
    class StavkaRacuna
    {
        public int idStavke;
        public artikli artikl;
        public float kolicina;

        public float Cijena() {
            return artikl.jedininicnaCijena * kolicina;
        }

    }
}
