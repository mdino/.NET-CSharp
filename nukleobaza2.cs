using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nukleus
{
    //5
    class Program
    {
        public class Par
        {
            public string Nukleobaza1;
            public string Nukleobaza2;
        }
        static void Main(string[] args)
        {
           
            string izbor="";
            Par NoviPar;
            List<Par> Parovi = new List<Par>() ;
            while (izbor != "i")
            {
                Console.WriteLine(@"
Izaberite opciju:
d) Dodaj nukleobazu u gen
p) Ispiši gen
i) Izlaz
");
                izbor = Console.ReadLine();
                Console.WriteLine("");
                switch (izbor)
                {
                    case "d":
                            {
                                Console.Write("Unesite nukelobazu (A,C,T ili G): ");
                                NoviPar = new Par() { Nukleobaza1 = Console.ReadLine() };
                                Console.WriteLine("");
                                if (NoviPar.Nukleobaza1 == "A" || NoviPar.Nukleobaza1 == "C" || NoviPar.Nukleobaza1 == "T" || NoviPar.Nukleobaza1 == "G")
                                {
                                    switch (NoviPar.Nukleobaza1)
                                    {
                                        case "A":
                                                {
                                                    NoviPar.Nukleobaza2 = "T";
                                                    break;
                                                }
                                        case "C":
                                                {
                                                    NoviPar.Nukleobaza2 = "G";
                                                    break;
                                                }
                                        case "T":
                                                {
                                                    NoviPar.Nukleobaza2 = "A";
                                                    break;
                                                }
                                        case "G":
                                                {
                                                    NoviPar.Nukleobaza2 = "C";
                                                    break;
                                                }
                                    }
                                    Parovi.Add(NoviPar);

                                }
                                else
                                {
                                    Console.WriteLine("Neispravan unos,Unesite nukelobazu (A,C,T ili G)");
                                }
                                break;
                            }
                    case "p":
                            {
                                
                                foreach (var item in Parovi)
                                {
                                    Console.Write(item.Nukleobaza1 + " ");
                                }
                                Console.WriteLine("");
                                foreach (var item in Parovi)
                                {
                                    Console.Write("| ");
                                }
                                Console.WriteLine("");
                                for (int i = 0; i < Parovi.Count;i++)
                                {
                                    Console.Write(Parovi[i].Nukleobaza2 + " "); //greska lista
                                }
                                Console.WriteLine("");
                                break;
                            }
                }
            }
        }
    }
}
