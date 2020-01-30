using LiveCharts;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ChartTest.Controls
{
    public sealed partial class LineControl : UserControl
    {
        public SeriesCollection SeriesCollection {
            get
            {
                return chart.Series;
            }
            set
            {
                chart.Series = value;
            }
        }

        public LineControl()
        {
            this.InitializeComponent();
        }
    }
}
