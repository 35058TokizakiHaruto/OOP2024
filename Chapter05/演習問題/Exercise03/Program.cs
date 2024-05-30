using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            string text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            CountOfnull(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);

        }

        private static void Exercise3_1(string text) {
          int count = text.Count();
            Console.WriteLine(text);
        }

        private static void Exercise3_2(string text) {
            string text1 = text.Replace("big", "small");
            Console.WriteLine(text1);
            Console.ReadKey();
        }

        public static int CountOfnull(string text,params string[] strArray) {
            int count = 0;
            foreach(string str in strArray) {
                int index = text.IndexOf(str,0);
                while(index != -1) {
                    count++;
                    index = text.IndexOf(str,index + str.Length);
                }
            }
            return count;
        }

        private static void Exercise3_4(string text) {
                    
        }  

        private static void Exercise3_5(string text) {
          
        }
    }
}
