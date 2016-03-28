using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak46
{
    class Pravokutnik
    {
        private int sirina =0;
        private int visina =0;

        public Pravokutnik(int sirina, int visina)
        {
            this.sirina = sirina;
            this.visina = visina;
        }

        public int izracunajPovrsinu()
        {
            return sirina * visina;
        }

        public int izracunajOpseg() 
        {
           return 2 * (sirina + visina);
        }

        public int IzracunajDijagonalu()
        {
            return (int) Math.Sqrt(Math.Pow(sirina, 2) + Math.Pow(visina, 2));
        }
    }


}
