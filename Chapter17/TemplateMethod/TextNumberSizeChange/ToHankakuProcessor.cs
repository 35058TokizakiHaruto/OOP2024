using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextFileProcessor;

namespace TextNumberSizeChange {
    class ToHankakuProcessor : TextProcessor {
        Dictionary<char, char> ToHankaku = new Dictionary<char, char>(){
            {'０', '0'}, {'１', '1'}, {'２', '2'}, {'３', '3'}, {'４', '4'},
            {'５', '5'}, {'６', '6'}, {'７', '7'}, {'８', '8'}, {'９', '9'}
        };
        private int _count;
        string _text = "";

        protected override void Initialize(string fname) {
            _count = 0;
        }

        protected override void Execute(string line) {

            _text += line;
            _count++;
        }

        protected override void Terminate() {
            Console.WriteLine("{0}行", _count);
            Console.WriteLine(_text);
        }
    }
}


