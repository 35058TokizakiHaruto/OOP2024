using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    public class Sale {
        //商品名
        public string ShopName { get; set; }

        //商品カテゴリ
        public string ProductcCategory { get; set; }

        //売上高
        public int Amount { get; set; }
    }
}
