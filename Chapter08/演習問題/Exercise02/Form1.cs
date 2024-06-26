using System.Globalization;

namespace Exercise02 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var doday = DateTime.Now;
            // 2024/6/25 11:58
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            tbDisp.Text = doday.ToString("g") + "\r\n";
            tbDisp.Text += doday.ToString("yyyy�NMM��dd�� HH��mm��ss�b" + "\r\n");
            tbDisp.Text += doday.ToString("ggyy�NM��d�� (dddd) ", culture);

        }


        private void btEx8_2_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Today;

            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {

                var str = string.Format("{0:yy/MM/dd}�̎��T��{1}:", dateTime, (DayOfWeek)dayofweek);
                //���T�̓��t���擾 (�߂�l���󂯎�邱��)
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
            var str = String.Format("�������Ԃ�{0}�~���b�ł���", duration.TotalMilliseconds);
            tbDisp.Text = str;
        }
    }
    class TimeWatch {
        private DateTime _time;

        public void Start() {
            _time = DateTime.Now;

        }
        public TimeSpan Stop() {
            return DateTime.Now - _time;
        }
    }
}
