using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            var r = (int)rSlider.Value;
            rValue.Text = r.ToString();
            var g = (int)gSlider.Value;
            gValue.Text = g.ToString();
            var b = (int)bSlider.Value;
            bValue.Text = b.ToString();

            var newcolor = Color.FromRgb((byte)r, (byte)g, (byte)b);

            colorArea.Background = new SolidColorBrush(newcolor);
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            var rValue = (byte)rSlider.Value;
            var gValue = (byte)gSlider.Value;
            var bValue = (byte)bSlider.Value;
            var color = new MyColor();
            color.Color = Color.FromRgb(rValue, gValue, bValue);

            stockList.Items.Add(color);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if(stockList.SelectedItem is MyColor selectedColor) {
                rValue.Text = selectedColor.Color.R.ToString();
                gValue.Text = selectedColor.Color.G.ToString();
                bValue.Text = selectedColor.Color.B.ToString();
            }
        }
    }
}
