/*Implementirat ćemo klasu Automobil s atributima broja šasije, marke automobila, 
naziva automobila, iznos CO2 ispušnih plinova te pokazivač na sljedeći element liste.
Zadatak Napravite vezanu listu i beskonačnu petlju koja omogućuje dodavanje elemenata i 
ispis elemenata iz liste. Element koji se upisuje je klasa Automobil. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba1
{

    public class Automobil { 

        int Sasija;
        string MarkaAutomobila;
        string NazivAutomobila;
        double CO2;
        List<Automobil> lista = new List<Automobil>();

        public void Unos(){
            Console.WriteLine("Broj sasija automobila: ");
            this.Sasija = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marka automobila: ");
            this.MarkaAutomobila = Console.ReadLine();
            Console.WriteLine("Naziv automobila: ");
            this.NazivAutomobila = Console.ReadLine();
            Console.WriteLine("CO2 automobila:");
            this.CO2 = Convert.ToDouble(Console.ReadLine());

        }


        public void Ispis()
        {
            Console.WriteLine("Broj sasije automobila " + this.Sasija);
            Console.WriteLine("Marka automobila " + this.MarkaAutomobila);
            Console.WriteLine("Naziv automobila " + this.NazivAutomobila);
            Console.WriteLine("CO2 automobila " + this.CO2);
        }


        public void UpisLista()
        {
            
            Automobil auto;
            auto = new Automobil();
            auto.Unos();
            lista.Add(auto);
        }

        public void ListaIspis()
        {

            foreach (var objekt in lista)
            {
                objekt.Ispis();
                Console.ReadKey();
            }
           

      }
    
    }// Automobil


    

    class Program
    {


        static void Main(string[] args)
        {
            int izbor;
            Automobil listaAutomobil = new Automobil();

            do
            {

                Console.WriteLine("1. Dodaj novi automobil ");
                Console.WriteLine("2. Ispisi sve automobile ");
                Console.WriteLine("9. Izlaz");

                izbor = Convert.ToInt32(Console.ReadLine());

                switch (izbor)
                {
                    case 1:
                        {
                            listaAutomobil.UpisLista();   
                            break;
                        }
                    case 2:
                        {
                            listaAutomobil.ListaIspis();
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }
                Console.Clear();
            } while (izbor != 9);

        }
    }
}
