using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_ {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //ヤードからメートルへの対応表を出力
                PrintYardToMeterList(1, 10);
            } else {
                //メートルからヤードへの対応表を出力
                PrintyardMeterToList(int.Parse(args[1]), int.Parse(args[2]));
            }
        }
        private static void PrintYdToMeterList(int start, int stop) {
            for (int yd = start; yd <= stop; yd++) {
                double meter = yardConverter.ToMeter(yd);
                Console.WriteLine("{0} it = {1:0.0000} m", yd, meter);
            }
        }
        private static void PrintydMeterToList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double yd = YardConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} it", meter, yd);
            }
        }
    }
}
