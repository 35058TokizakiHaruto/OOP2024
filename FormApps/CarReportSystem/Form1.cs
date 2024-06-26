using System.ComponentModel;
using System.Data;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listcarReports = new BindingList<CarReport>();


        //コンストラクタ
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listcarReports;
        }

        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
            };
            listcarReports.Add(carReport);
        }
    }
}
