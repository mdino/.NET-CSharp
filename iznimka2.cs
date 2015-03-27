
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace vjezba1
{


    class Program
    {


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter Number: ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Number: ");
                int second = Convert.ToInt32(Console.ReadLine());

                int Resultat = first / second;
                Console.WriteLine("Result= {0}", Resultat);

            }

            catch (FormatException)
            {

                Console.WriteLine("Please enter a number: ");
            }

            catch (OverflowException)
            {

                Console.WriteLine("Only number between {0} && {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Nemozemo podjelit sa nulom");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

              

            


            
        }
    }
}
