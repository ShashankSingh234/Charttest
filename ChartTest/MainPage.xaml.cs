using LiveCharts;
using LiveCharts.Uwp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ChartTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            ChartControl.SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double> { 2, 3, 3.5, 4, 4.5, 4.6, 4.7, 4.8, 4.9, 5, 4.5, 4.4, 4.5, 4, 4.5, 5, 4.5, 4.2, 4, 3.8, 3.5, 3.3, 3, 3.5,
                    2.5, 3, 3.5, 4, 4.5, 4.6, 4.7, 4.8, 4.9, 5, 4.5, 4.4, 4.5, 4, 4.5, 4, 3,
                    2.5, 3, 3.5, 4, 4.5, 4.6, 4.7, 4.8, 4.9, 5, 4.5, 4.4, 4.5, 4, 4.5, 5, 4.5,
                    2.5, 3, 3.5, 4, 4.5, 4.6, 4.7, 4.8, 4.9, 5, 4.5, 4.4, 4.5, 4, 4.5, 4, 3 },
                },
                new ColumnSeries
                {
                    Values = new ChartValues<double> { 1, 2, 1.5, 1, 1, 2, 1.5, 1, 1, 2, 1.2, 1.5, 1, 2, 2, 1.5, 1, 2, 2, 1.5, 1, 2, 2, 1.2,
                    1, 2, 2, 1.5, 1, 2, 2, 1.4, 1, 2, 1.4, 1.1, 1, 2, 2, 1.2, 1, 2, 2, 1.4, 1, 2, 2, 1.5,
                    1, 2, 2, 2.1, 1, 2, 2, 2.3, 1, 2, 2, 2.1, 1, 2, 2, 1.1, 1, 2, 0.9, 1.1, 1, 2, 2, 1.3,
                    1, 2, 2 },
                    ColumnPadding = 0
                }
            };
        }
    }
}
