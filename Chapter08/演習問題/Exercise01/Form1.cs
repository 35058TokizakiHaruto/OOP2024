using System.Globalization;

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
            tbDisp.Text += doday.ToString("yyyy�NMM��dd�� HH��mm��ss�b");
            tbDisp.Text += doday.ToString("ggyy�NM��d�� (dddd) ",culture);

        }

    }
}
