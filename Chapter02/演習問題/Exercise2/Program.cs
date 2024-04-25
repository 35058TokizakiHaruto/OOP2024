using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    public class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //インチからメートルへの対応表を出力
                PrintInchToMeterList(1, 10);
            } else {
                //メートルからインチへの対応表を出力
                PrintinchMeterToList(int.Parse(args[1]), int.Parse(args[2]));
            }
        }
        private static void PrintInchToMeterList(int start, int stop) {
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0} it = {1:0.0000} m", inch, meter);
            }
        }
        private static void PrintinchMeterToList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} it", meter, inch);
            }
        }
    }
}
