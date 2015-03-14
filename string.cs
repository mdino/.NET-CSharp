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
            string fname, lname;
            fname = "Musliu";
            lname = "Dino";

            string fullname = lname + fname;

            Console.WriteLine("Full Name: {0}", fullname);

            char[] letters = { 'H', 'i' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);


            string[] poruka = { "bok svima", "koji ste cool" };
            string ispis= String.Join(" ", poruka);

            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            Console.ReadKey();


        }
    }
}
