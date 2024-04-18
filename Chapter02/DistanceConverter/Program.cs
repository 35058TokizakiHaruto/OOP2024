﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    internal class Program {
        static void Main(string[] args) {
            if(args.Length >= 1 && args[0] =="-tom") {
                //フィートからメートルへの対応表を出力
            } else {
                //メートルからフィートへの対応表を出力
               
                }
            }
            private static void PrintfeetToMeterList(int start, int stop) {
                for (int feet = 1; feet <= 10; feet++) {
                    double meter = FeetToMeter(feet);
                    Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
                }
            }
            private static void PrintfeetMeterToList(int start, int stop) {
            for (int meter = 1; meter <= 10; meter++) {
                double feet = FeetMeterTo(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);



                //フィートからメートルを求める
                static double FeetToMeter(int feet) {
            return feet * 0.3048;
        }
        //メートルからフィートを求める
        static double MeterToFeet(int meter) {
            return meter * 0.3048;
        }
    }
}
