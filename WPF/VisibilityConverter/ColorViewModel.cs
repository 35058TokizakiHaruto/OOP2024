using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace VisibilityConverter {
    public class ColorViewModel {
        private static IList<ColorViewModel> colors = new List<ColorViewModel> {
            new ColorViewModel{Name="赤", color = Colors.Red},
            new ColorViewModel{Name="黄", color = Colors.Yellow},
            new ColorViewModel{Name="青", color = Colors.Blue},
        };

        public static IList<ColorViewModel> ColorList { get { return colors; } }
        public string Name { get; set; }
        public Color color { get; set; }
    }
}
