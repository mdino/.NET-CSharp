using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string[] splitNumbers = number.Split('.');
            int limit0 = Convert.ToInt32(splitNumbers[0]);
            for(int i=0;i<limit0;i++){
                Console.WriteLine("x");
            }

            Console.WriteLine(splitNumbers[1].Length);
            
            
            
            string s = "there is a cat";
	// Split string on spaces.
	// ... This will separate all the words.
	string[] words = s.Split(' ');
	foreach (string word in words)
	{
	    Console.WriteLine(word);
	}

            Console.ReadKey();
        }
    }
}
