using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba1
{
    class Program
    {

       
        static void Main(string[] args)
        {
            // primjer ispisa
            string fname, lname;
            fname = "Musliu";
            lname = "Dino";
            string fullname = lname + fname;
            Console.WriteLine("Full Name: {0}", fullname);
            
            //char u string
            char[] letters = { 'H', 'i' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: " + greetings);

            // ispis svih polja stringova
            string[] poruka = { "bok svima", "koji ste cool" };
            string ispis= String.Join(" ", poruka);
            
            // ispis vremena
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            
            // ispis nakon odredenog indeksa 
            string ispis = "JedanDvaTri";

            string razdvoji=ispis.Substring(5);
            Console.WriteLine("Ispis: "+ razdvoji);
            Console.ReadKey();

            // ispis sredine, pocni od 5 i ispisi 3 slova
             string ispis2 = "JedanDvaTri";

            string razdvoji2=ispis2.Substring(5,3);
            Console.WriteLine("Ispis: "+ razdvoji2);
            Console.ReadKey();
            
            
            Console.ReadKey();


        }
    }
}
