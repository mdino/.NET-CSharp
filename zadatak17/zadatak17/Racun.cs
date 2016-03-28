using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak17
{
    class Racun
    {
        public int brojRacuna;
        public DateTime datumKreiranja;
        public string prodavac;
        public string nacinPlacanja;
        public List<StavkaRacuna> stavke;
        
        public float Ukupni_iznos(){

            float iznos = 0;
            foreach (var ispis in stavke)
            {
                iznos += ispis.Cijena();
            }
            return iznos;
        }

    }
}
