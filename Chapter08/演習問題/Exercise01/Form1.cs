using System.Globalization;
using System.Net.WebSockets;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent(GetBtEx8_1());
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var doday = DateTime.Now;
            // 2024/6/25 11:58
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            tbDisp.Text = doday.ToString("g") + "\r\n";
            tbDisp.Text += doday.ToString("yyyy年MM月dd日 HH時mm分ss秒" + "\r\n");
            tbDisp.Text += doday.ToString("ggyy年M月d日 (dddd) ", culture);

        }

        private void btEx8_2_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Today;

            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {

                var str = string.Format("{0:yy/MM/dd}の次週の{1}:", dateTime, (DayOfWeek)dayofweek);
                //来週の日付を取得 (戻り値を受け取ること)
                tbDisp.Text += str + NextWeek(dateTime, (DayOfWeek)dayofweek) + "\r\n";

                //NextWeek(dateTime,(DayOfWeek)dayofWeek);
            }
        }

        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            var nextweek = date.AddDays(7);
            var day = (int)dayOfWeek - (int)date.DayOfWeek;
            return nextweek.AddDays(day);
        }

        private void btEx8_3_Click(object sender, EventArgs e) {
            var tW = new TimeWatch();
            tW.Start();
            Thread.Sleep(1000);
            TimeSpan duration = tW.Stop();
            var str = String.Format("処理時間は{0}ミリ秒でした", duration.TotalMilliseconds);
            tbDisp.Text = str;
        }
    }
    class TimeWatch {
        private DateTime _time;

        public void Start() {



        }

        public TimeSpan Stop() {
            
        }
    }
}

