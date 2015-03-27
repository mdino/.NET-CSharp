
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
                Console.WriteLine("Enter First number:");
                int FN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second number:");
                int SN = Convert.ToInt32(Console.ReadLine());

                int Result = FN / SN;
            }

            catch (Exception ex)
            {

                string filePath = @"C:\Users\Dino\Desktop\Log.txt";

                if (File.Exists(filePath))
                {

                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType().Name);
                    sw.WriteLine(); // novi red
                    sw.Write(ex.Message);
                    sw.Close();
                    Console.WriteLine("There is Problem.");
                }

                else
                {
                    throw new FileNotFoundException(filePath + "is not present", ex);
                }

            }

            


            
        }
    }
}
