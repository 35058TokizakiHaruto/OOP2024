using Section01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books
                 .Max(b => b.Price);
            var book = Library.Books
                .First(b => b.Price == max);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var query = Library.Books
                .GroupBy(b => b.PublishedYear)
                .Select(g => new { PublishedYear = g.Key, Count = g.Count() })
                .OrderBy(g => g.PublishedYear);

            foreach (var item in query) {
                Console.WriteLine("{0}年{1}冊", item.PublishedYear, item.Count);

            }
        }

        private static void Exercise1_4() {
            var sortedbooks = Library.Books
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new {
                    book.Title,
                    book.PublishedYear,
                    book.Price,
                    CategoryName = category.Name

                })
                 .OrderByDescending(x => x.PublishedYear)
                 .ThenByDescending(x => x.Price);

            foreach (var book in sortedbooks)
                Console.WriteLine("{0}年{1}円{2}({3})",
                    book.PublishedYear,
                    book.Price,
                    book.Title,
                    book.CategoryName
                    );
        }

        private static void Exercise1_5() {
            var names = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,
                      book => book.CategoryId,
                      category => category.Id,
                     (book, category) => category.Name).Distinct();
            foreach (var name in names) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Categories
                .GroupJoin(Library.Books,
                c => c.Id,
                c => c.CategoryId,
                (c, books) => new { Category = c.Name, Books = books })
                .OrderBy(g => g.Category);
            foreach (var group in groups) {
                Console.WriteLine("#" + group.Category);
                foreach (var book in group.Books) {
                    Console.WriteLine($"  {book.Title}");
                }
            }
        }

        private static void Exercise1_7() {
            var categorysid = Library.Categories
                .Single(c => c.Name == "Development").Id;
            var query = Library.Books.Where(b => b.CategoryId == categorysid)
                .GroupBy(b => b.PublishedYear)
                .OrderBy(b => b.Key);
            foreach (var group in query) {
                Console.WriteLine("#{0}年", group.Key);
                foreach (var item in group) {
                    Console.WriteLine("   {0}", item.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var categorys = Library.Categories
                  .GroupJoin(Library.Books,
                b => b.Id,
                c => c.CategoryId,
                (category, bookGroup) => new {
                    Category = category.Name,
                    Books = bookGroup
                })
                  .Where(g => g.Books.Count() >= 4)
                  .Select(g => g.Category);

            foreach (var category in categorys) {
                Console.WriteLine(category);
            }
        }
    }
}
