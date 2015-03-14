using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba1
{

    struct Books {
        public string title;
        public string author;
        public string subject;
        public int book_id;

    };

    class Program
    {

        static void Main(string[] args)
        {

            Books book1;

            book1.title = "C Programing";
            book1.book_id = 521552;

            Console.WriteLine("Book 1 title: " + book1.title);
            Console.WriteLine("Book 1 book id: " +book1.book_id);
            Console.ReadKey();
        }
    }
}
