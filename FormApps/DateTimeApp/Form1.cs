using System.Drawing.Text;

namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e) {
            var today = DateTime.Today;

            TimeSpan diff = today - dtpDate.Value;

            //tbDisp.Text = "ÅZÅZì˙ñ⁄";
            tbDisp.Text = (diff.Days + 1) + "ì˙ñ⁄";

        }

        private void btDayBefore_Click(object sender, EventArgs e) {

            var past = dtpDate.Value.AddDays(-(double)nud.Value);
            tbDisp.Text = past.ToString("D");
        }

        private void btDayAfter_Click(object sender, EventArgs e) {
            var future = dtpDate.Value.AddDays(+(double)nud.Value);
            tbDisp.Text = future.ToString("D");
        }

        private void btDayAge_Click(object sender, EventArgs e) {
            var birthday = dtpDate.Value;
            var today = DateTime.Today;
            int age = GetAge(birthday, today);
            tbDisp.Text = age.ToString("D") + "çŒ";
        }

        public static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < (birthday.AddYears(-age)).AddDays(-1)) {
                age--;
            }
            return age;
        }
    }
}
