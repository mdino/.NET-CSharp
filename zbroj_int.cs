//Napravite aplikaciju koja od korisnika traži unos dva decimalna zbroja te računa njihov zbroj. U aplikaciji se za pohranu smije koristiti samo int tip podataka. Zbog ovog ograničenja najjednostavnije je napraviti strukturu/klasu za pohranu decimalnih brojeva. 

using System;
using Sytem.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba1
{
    struct decimalni
    {
        public int cijeli;
        public int desetinka;
    };


    class Program
    {

        static void Main(string[] args)
        {

           decimalni broj1;
           decimalni broj2;



            //prvi
            Console.WriteLine("Unesi prvi broj \nUnesi cijeli dio: ");
            broj1.cijeli = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi desetinku: ");
            broj1.desetinka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vaš decimalni broj je: " + broj1.cijeli + "," + broj1.desetinka + "\n\n");
            

            //drugi
            Console.WriteLine("Unesi drugi broj \n\nUnesi cijeli dio: ");
            broj2.cijeli = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi desetinku: ");
            broj2.desetinka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vaš decimalni broj je: " + broj2.cijeli + "," + broj2.desetinka);

            int zbroj = broj1.desetinka + broj2.desetinka;
            int desnoOd;
            int lijevoOd;

            desnoOd=zbroj % 10;
            lijevoOd=zbroj/ 10;
            int ZbrojUkupno = broj1.cijeli + broj2.cijeli + lijevoOd;

            Console.WriteLine("Zbroj= " + ZbrojUkupno + "," + desnoOd);


            





            Console.ReadKey();


        }
    
    }
