﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CustomerApp.Objects {
    public class Customer {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 電話番号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 住所
        /// </summary>
        public string Address { get; set; }
        ///<summary>
        ///画像保存
        ///</summary>
        public byte[] ImageData { get; set; }

        public override string ToString() {
            return $"{Id} {Name} {Phone} {Address} {ImageData}";
        }
    }
}
