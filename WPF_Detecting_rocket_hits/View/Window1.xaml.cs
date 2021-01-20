using LiveCharts;
using LiveCharts.Wpf;
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
using System.Windows.Shapes;

namespace PL.View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();


            //Func<ChartPoint, string> labelPoint = chartPoint =>
            //    string.Format("({0:P})",  chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Sucsess",
                    Values = new ChartValues<double> {3},
                    //DataLabels = true,
                    //LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Failed",
                    Values = new ChartValues<double> {9},
                    //DataLabels = true,
                    //LabelPoint = labelPoint
                },
               
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
}
