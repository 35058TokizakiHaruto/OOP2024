using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
         List<RssItem> items;
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(Rss_ComboBox.Text);
                var xdoc = XDocument.Load(url);

                var items = xdoc.Root.Descendants("item")
                                    .Select(item => new ItemData {
                                        Title = item.Element("title").Value,
                                        Link = item.Element("link").Value,
                                    });

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void LbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbRssTitle.SelectedItem != null) {
                var selectedTitle = lbRssTitle.SelectedItem.ToString();
                var selectedItem = items.FirstOrDefault(item => item.Title == selectedTitle);

                if (selectedItem != null) {
                    webView21.Source = new Uri(selectedItem.Link);
                }
            }
        }
        
        private void cbURLorFavoriteName(object sender, EventArgs e) {
            Rss_ComboBox.Items.Add("主要");
            Rss_ComboBox.Items.Add("国内");
            Rss_ComboBox.Items.Add("国際");
            Rss_ComboBox.Items.Add("経済");
            Rss_ComboBox.Items.Add("エンタメ");
            Rss_ComboBox.Items.Add("スポーツ");
            Rss_ComboBox.Items.Add("IT");
            Rss_ComboBox.Items.Add("科学");
            Rss_ComboBox.Items.Add("地域");

        }
    }
}
//データ格納用のクラス
public class ItemData {
    public string Title { get; set; }
    public string Link { get; set; }

}

