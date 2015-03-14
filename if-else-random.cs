using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba1
{
    class Program
    {
        static public int age;

        static void godine()
        {
            if (age > 18)
            {
                Console.WriteLine("You can enter");
            }
            else if (age < 18)
            {
                Console.WriteLine("You can't enter");
            }
            else
            {
                Console.WriteLine(" Lol");
            }

        }






        static void Main(string[] args)
        {
            Console.WriteLine("1- random, 2-enter");
            int broj = Convert.ToInt32(Console.ReadLine());
            

            if (broj == 1)
            {
                Random numberGenerator = new Random();
                age = numberGenerator.Next(1, 11);
                Console.WriteLine(age);
                godine();
            }

            if (broj == 2)
            {
                Console.Write("How old are u: ");
                age = Convert.ToInt32(Console.ReadLine());
                godine();
            }

            
            Console.ReadKey();
            
        }

       
    }

}
