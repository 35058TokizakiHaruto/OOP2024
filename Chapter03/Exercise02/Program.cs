using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London",
                "Paris", "Berlin", "Canberra", "Hong Kong",
};
            Console.WriteLine("***** 3.2.1 *****");
            Exercise2_1(names);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.1 *****");
            Exercise2_2(names);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.1 *****");
            Exercise2_3(names);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.1 *****");           
            Exercise2_4(names);
            Console.WriteLine();
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力、空行で終了");
            //string.IsNullOrEmpty() ←このメソッドを使って空行か判定する
            do {
                //入力処理
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) {
                    break;//空行だったら抜ける
                }
                int index = names.FindIndex(n => n == line);
                Console.WriteLine(index);
            }while (true);

        }

        private static void Exercise2_2(List<char> names) {
            if (names.Contains('o'){
                Console.WriteLine(names);
            }
        }

        private static void Exercise2_3(List<string> names) {
           
        }

        private static void Exercise2_4(List<string> names) {
           
        }
    }
}
