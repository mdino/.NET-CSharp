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
            Console.WriteLine("Upisi ime:");
            string ime = Console.ReadLine();
            Console.WriteLine("Upisi prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("Pozdrav {0},{1}", ime, prezime);

            Console.ReadKey();
            Console.Write("\b \b");
        }
    }
}
