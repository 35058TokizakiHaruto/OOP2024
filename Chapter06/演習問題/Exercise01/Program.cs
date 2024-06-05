using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
            Console.WriteLine("-----");
        }


        private static void Exercise1_1(int[] numbers) {
            var Max = numbers.Max();
            Console.WriteLine(Max.ToString());
        }

        private static void Exercise1_2(int[] numbers) {
            int[] last2 = numbers.Skip(numbers.Length - 2).ToArray();
            foreach (var x in last2) {
                Console.WriteLine(x);
            }

        }
        private static void Exercise1_3(int[] numbers) {
            var strings = numbers.Select(x => x.ToString().ToArray());
            foreach (var result in strings) {
                Console.WriteLine(result);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            var sortenumbers = numbers.OrderBy(x => x).Take(3).ToArray();
            foreach (var x in sortenumbers) {
                Console.WriteLine(x.ToString());
            }
        }
        private static void Exercise1_5(int[] numbers) {
            var results = numbers.Distinct().ToList();
            int intCount = numbers.Count(x => 10 < x);
            Console.WriteLine(intCount);
        }
    }
}
