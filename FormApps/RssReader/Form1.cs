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
        Dictionary<string, string> rssDict;
        public Form1() {

            InitializeComponent();

            rssDict = new Dictionary<string, string>() {
                 { "主要", "https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
                 { "国内", "https://news.yahoo.co.jp/rss/topics/domestic.xml" },
                 { "国際", "https://news.yahoo.co.jp/rss/topics/world.xml" },
                 { "経済", "https://news.yahoo.co.jp/rss/topics/business.xml" },
                 { "エンタメ", "https://news.yahoo.co.jp/rss/topics/business.xml" },
                 { "スポーツ", "https://news.yahoo.co.jp/rss/topics/sports.xml" },
                 { "IT", "https://news.yahoo.co.jp/rss/topics/it.xml" },
                 { "科学", "https://news.yahoo.co.jp/rss/topics/science.xml" },
                 { "地域", "https://news.yahoo.co.jp/rss/topics/local.xml" },
                };
            Rss_ComboBox.Items.AddRange(rssDict.Keys).ToArray();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(Rss_ComboBox.Text);
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                                   .Select(item => new RssItem {
                                       Title = item.Element("title").Value,
                                       Link = item.Element("link").Value,
                                   }).ToList();

                foreach (var title in items) {
                    lbRssTitle.Items.Add(title.Title);
                }
            }

            using (var wc = new WebClient()) {
                var url = wc.OpenRead(Rss_ComboBox.Text);
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                                   .Select(item => new RssItem {
                                       Title = item.Element("title").Value,
                                       Link = item.Element("link").Value,
                                   }).ToList();

                foreach (var title in items) {
                    lbRssTitle.Items.Add(title.Title);
                }
            }
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
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}

//データ格納用のクラス
public class RssItem {
    public string Title { get; set; }
    public string Link { get; set; }

}

