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
            int izbor;

            do
            {
                
                Console.WriteLine("1. ");
                Console.WriteLine("2. ");
                Console.WriteLine("3. ");
                Console.WriteLine("4. ");
                Console.WriteLine("5. ");
                Console.WriteLine("9. Izlaz");

                izbor = Convert.ToInt32(Console.ReadLine());

                switch (izbor)
                {
                    case 1:
                        {
                        Console.WriteLine("Prvi");
                        Console.ReadKey();

                        break;
                        }
                    case 2:{
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
