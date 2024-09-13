using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    internal class Program {
        static void Main(string[] args) {
            // InsertBooks();
            AddAuthors();
            //AddBooks();
            DiaplayAllBooks();
        }

        //データの変更(更新)
        private static void UopdateBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        //データの削除
        private static void DeleteBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if (book != null) {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }
        //著者の追加
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子",
                };
                db.Authors.Add(author1);
                var author2 = new Author {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治",
                };
                db.Authors.Add(author2);
                db.SaveChanges();

            }
        }

        private static void AddAuthors2() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛",
                };
                db.Authors.Add(author1);
                var author2 = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成",
                };
                db.Authors.Add(author2);
                db.SaveChanges();

            }
        }

        // 書籍データの追加
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                //Authorから該当するデータを取得する
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);
                //Authorから該当するデータを取得する
                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",                  
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges(); //データベース更新
            }
        }

        private static void AddBooks2() {
            using (var db = new BooksDbContext()) {
                //Authorから該当するデータを取得する
                var author1 = db.Authors.Single(a => a.Name == "菊池寛");
                var book1 = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2003,
                    Author = author1,
                };
                db.Books.Add(book1);
                //Authorから該当するデータを取得する
                var author2 = db.Authors.Single(a => a.Name == "川端康成");
                var book2 = new Book {
                    Title = "伊豆の踊り子",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges(); //データベース更新
            }
        }


        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges(); //データベースを更新
            }
        }

        //テーブルの全表示
        static void DiaplayAllBooks() {
            var books = GetBooks();
            foreach (var book in GetBooks()) {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            Console.ReadLine();
        }
        //p344 問題13.1.2
        static void DisplayAllBooks2() {
            using (var db = new BooksDbContext()) {
                foreach (var book in db.Books.ToList()) {
                    Console.WriteLine("{0} {1} {2}{3:yyyy/MM/dd})",
                        book.Title, book.PublishedYear,
                        book.Author.Name, book.Author.Birthday
                    );
                }
            }
        }

        //データの取得
        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {
                return db.Books
                    //Where(book => book.Author.Name.StartsWith("夏目"))
                    .ToList();
            }
        }
    }
}




