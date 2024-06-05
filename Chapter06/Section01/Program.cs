using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var books = Books.GetBooks().OrderByDescending(b => b.Price).ToArray();

            //books.ForEach(b => Console.WriteLine(b.Title + ":" + b.Price));

            foreach (var book in books) {
                Console.WriteLine(book.Title + ":" + book.Price);
            }
        }
    }
}
