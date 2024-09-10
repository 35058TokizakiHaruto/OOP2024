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
                                    .Select(item => new RssItem {
                                        Title = item.Element("title").Value,
                                        Link = item.Element("link").Value,
                                    });

                foreach (var title in items) {
                    lbRssTitle.Items.Add(title.Title);
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


        private void LbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                if (lbRssTitle.SelectedItem != null) {
                    var selectedTitle = lbRssTitle.SelectedItem.ToString();
                    if (items != null) {
                        var selectedItem = items.FirstOrDefault(item => item.Title == selectedTitle);

                        if (selectedItem != null) {
                            if (!string.IsNullOrEmpty(selectedItem.Link)) {
                                webView21.Source = new Uri(selectedItem.Link);
                            } else {
                                MessageBox.Show("Selected item link is null or empty.");
                            }
                        } else {
                            MessageBox.Show("Selected item not found.");
                        }
                    } else {
                        MessageBox.Show("Items collection is not initialized.");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }




    }
}
//データ格納用のクラス
public class RssItem {
    public string Title { get; set; }
    public string Link { get; set; }

}

