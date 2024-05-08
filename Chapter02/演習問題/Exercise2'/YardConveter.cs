using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    internal class YardConveter {
        //private const double ratio = 0.91440; 　//定数
        public static readonly double ratio = 0.91440; //定数(外部にも公開する場合)

        //メートルからヤードを求める
        public static double FromMeter(double meter) {
            return meter / ratio;
        }

        //ヤードからメートルを求める
        public static double ToMeter(double yd) {
            return yd * ratio;
        }
    }
}
