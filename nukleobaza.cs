using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        struct nukleobaza
        {
            public string nukleobaza1;
            public string nukleobaza2;
        };

        static void Main(string[] args)
        {
            int izbor = 0;
            List<nukleobaza> listaNukleobaza = new List<nukleobaza>();
            do
            {
                Console.WriteLine("Izbor: ");
                izbor = Convert.ToInt32(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        nukleobaza novaNukleobaza = new nukleobaza();
                        Console.WriteLine("Unesite nukleobazu1: ");
                        novaNukleobaza.nukleobaza1 = Console.ReadLine();
                        Console.WriteLine("Unesite nukleobazu2: ");
                        novaNukleobaza.nukleobaza2 = Console.ReadLine();
                        listaNukleobaza.Add(novaNukleobaza);
                        break;
                    case 2:
                        for (int i = 0; i < listaNukleobaza.Count; i++)
                        {
                            Console.WriteLine(listaNukleobaza[i].nukleobaza1[0] + "-" + listaNukleobaza[i].nukleobaza2[0] + ",\n" +
                                              listaNukleobaza[i].nukleobaza1[0] + "-" + listaNukleobaza[i].nukleobaza2[1] + ",\n" +
                                              listaNukleobaza[i].nukleobaza1[1] + "-" + listaNukleobaza[i].nukleobaza2[0] + ",\n" +
                                              listaNukleobaza[i].nukleobaza1[1] + "-" + listaNukleobaza[i].nukleobaza2[1] + "\n");
                        }
                        break;
                    case 3:
                        return;
                }
            } while (izbor != 9);
        }
    }
}
