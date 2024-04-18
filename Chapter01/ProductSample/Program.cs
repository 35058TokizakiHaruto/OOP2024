using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product karinto = new Product(123,"かりんとう",180);
            Product daihuku = new Product(235, "大福もち", 160);

            int kprice = karinto.Price; //税抜きの金額
            int ktaxIncluded = karinto.GetPriceIncludingTax(); //税込みの金額

            int dprice = daihuku.Price;
            int dtaxIncluded = daihuku.GetPriceIncludingTax();
            

            Console.WriteLine(karinto.Name + "の税込み金額" + ktaxIncluded + "円【税抜き"+ kprice + "円】" );
            Console.WriteLine(daihuku.Name + "の税込み金額" + dtaxIncluded + "円【税抜き" + dprice + "円】");




















        }
    }
}
