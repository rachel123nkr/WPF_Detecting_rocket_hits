using BE;
using LiveCharts;
using LiveCharts.Wpf;
using PL.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace PL.View
{
    /// <summary>
    /// Interaction logic for graphUC.xaml
    /// </summary>
    public partial class graphUC : UserControl,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        internal MainWindow Myfather { get; set; }
        internal TheViewModel CurrentVM { get; set; }

        internal List<double> dis;

        private int numOfSuccess;
        private int numOfFailers;

        private SeriesCollection seriesCollection;

        private List<string> labelsList;

        //private int[] labels;

        public int NumOfSuccess {
            get { return numOfSuccess; }
            set
            {
                numOfSuccess = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("NumOfSuccess");
            }
        }
        public int NumOfFailers {
            get { return numOfFailers; }
            set
            {
                numOfFailers = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("NumOfFailers");
            }
        }

        public SeriesCollection SeriesCollection
        {
            get { return seriesCollection; }
            set
            {
                seriesCollection = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("seriesCollection");
            }
        }
        private string[] labels;
        public string[] Labels //{ get; set; }
        {
            get { return labels; }
            set
            {
                labels = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("labels");
}
        }

        public graphUC(MainWindow father)
        {
            InitializeComponent();
            Myfather = father;
            CurrentVM =(TheViewModel) father.DataContext;


            PointLabel = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            Init();
            
        }

        private void Init()
        {
            NumOfFailers = 0;
            NumOfSuccess = 0;
            dis = new List<double>() ;
            this.SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Values = new ChartValues<double>(dis)
                }
            };

            this.Labels = new string[] { "" };
            labelsList = new List<string>();




           
        }

        private void buildGrhaph()
        {
            List<BE.Fall> fallsL=CurrentVM.CurrentModel.Bl.FallList();
            BE.Fall fall;
            if (fallsL.Count == 0)
                return;
            
            for (int i = fallsL.Count-1; i > 0; i++)
            {

                fall = fallsL[i];
                
                ReportFall[] ReportToEstimate = CurrentVM.CurrentModel.Bl.GetReportBetweenTime(DateTime.Now);
                if (ReportToEstimate == null)
                {
                    return;
                }
                if (ReportToEstimate.Length == 0)
                {
                    return;
                }
                Coordinate[] estimates = CurrentVM.CurrentModel.CurKmeans.returnAvgPerGroupFromRep(ReportToEstimate);
                //Coordinate fall1 = new Coordinate(32.0523655, 34.815199277777772);
                double meter = CurrentVM.CurrentModel.Bl.GetDistanceBetweenPoints(estimates[0], fall.CoordinateF);

                this.dis.Add(meter / 1000);
                labelsList.Add(fall.DateFall.ToString());///here
            }

            Labels = labelsList.ToArray<string>();
            this.SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Values = new ChartValues<double>(dis)
                }
            };
            Labels = new string[] {"5", "6", "8"};

            this.DataContext = this;
            Myfather.shell.Content = this;
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartpoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartpoint.SeriesView;
            selectedSeries.PushOut = 8;
        }

        private void Stam_Click(object sender, RoutedEventArgs e)
        {
            //Window1 win2 = new Window1();
           // win2.show();
        }

        private void SuccessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                DateTime? from = fromDatePicker2.SelectedDate;
                DateTime? to = toDatePicker2.SelectedDate;
                if (from == null)
                    throw new Exception("you must choose \"from\" date");
                if (to == null)
                    throw new Exception("you must choose \"to\" date");

                buildPie((DateTime)from, (DateTime)to);

            }
            catch (Exception ex)
            {
                TextInDialog2.Text = ex.Message;
                 dialogBox2.IsOpen = true;
               // MessageBox.Show(ex.Message);

            }

        }

        private void ShowGraphBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime? from = fromDatePicker.SelectedDate;
            DateTime? to = toDatePicker.SelectedDate;
                if (from == null)
                    throw new Exception("you must choose \"from\" date");
                if (to == null)
                    throw new Exception("you must choose \"to\" date");

                buildGrhaph((DateTime)from, (DateTime)to);

            }
            catch (Exception ex)
            {
                TextInDialog.Text = ex.Message;
                dialogBox.IsOpen = true;
                // MessageBox.Show(ex.Message);
               
            }

        }

        private void buildGrhaph(DateTime from, DateTime to)
        {
            Init();
            List<BE.Fall> fallsL = CurrentVM.CurrentModel.Bl.FallList();
            IEnumerable<BE.Fall> fallQuery = fallsL.Where(fallX => (fallX.DateFall.Date >= from) && (fallX.DateFall.Date <= to));
            fallsL = fallQuery.ToList();
            BE.Fall fall;
            if (fallsL.Count == 0)
                return;

            for (int i = 0; i <fallsL.Count; i++)
            {

                fall = fallsL[i];

                //ReportFall[] ReportToEstimate = CurrentVM.CurrentModel.Bl.GetReportBetweenTime(DateTime.Now);
                ReportFall[] ReportToEstimate = CurrentVM.CurrentModel.Bl.GetReportBetweenTime(fall.DateFall);
                if (ReportToEstimate == null)
                {
                    return;
                }
                if (ReportToEstimate.Length == 0)
                {
                    ///return;/////
                    continue;
                }
                Coordinate[] estimates = CurrentVM.CurrentModel.CurKmeans.returnAvgPerGroupFromRep(ReportToEstimate);
                //Coordinate fall1 = new Coordinate(32.0523655, 34.815199277777772);
                double meter = CurrentVM.CurrentModel.Bl.GetDistanceBetweenPoints(estimates[0], fall.CoordinateF);

                this.dis.Add(meter / 1000);
                labelsList.Add(fall.DateFall.ToString());//here
            }

            Labels = labelsList.ToArray<string>();
            this.SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Values = new ChartValues<double>(dis),
                    DataLabels = true,
                    LabelPoint = point => point.Y + "K"
                }
            };

            //Labels = new int[] { 5, 6, 8, 6, 8, 6, 8, 7 };

            this.DataContext = this;
            Myfather.shell.Content = this;
        }

        private void ShowAnalysisBtn2_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                DateTime? from = fromDatePicker2.SelectedDate;
                DateTime? to = toDatePicker2.SelectedDate;
                if (from == null)
                    throw new Exception("you must choose \"from\" date");
                if (to == null)
                    throw new Exception("you must choose \"to\" date");

                buildPie((DateTime)from, (DateTime)to);

            }
            catch (Exception ex)
            {
                TextInDialog2.Text = ex.Message;
                dialogBox2.IsOpen = true;
                // MessageBox.Show(ex.Message);

            }

        }


        private void buildPie(DateTime from, DateTime to)
        {
            Init();
            List<BE.Fall> fallsL = CurrentVM.CurrentModel.Bl.FallList();
            IEnumerable<BE.Fall> fallQuery = fallsL.Where(fallX => (fallX.DateFall.Date >= from) && (fallX.DateFall.Date <= to));
            fallsL = fallQuery.ToList();
            BE.Fall fall;
            if (fallsL.Count == 0)
                return;

            for (int i = 0; i < fallsL.Count; i++)
            {

                fall = fallsL[i];

                //ReportFall[] ReportToEstimate = CurrentVM.CurrentModel.Bl.GetReportBetweenTime(DateTime.Now);
                ReportFall[] ReportToEstimate = CurrentVM.CurrentModel.Bl.GetReportBetweenTime(fall.DateFall);
                if (ReportToEstimate == null)
                {
                    return;
                }
                if (ReportToEstimate.Length == 0)
                {
                    ///return;/////
                    continue;
                }
                Coordinate[] estimates = CurrentVM.CurrentModel.CurKmeans.returnAvgPerGroupFromRep(ReportToEstimate);
                //Coordinate fall1 = new Coordinate(32.0523655, 34.815199277777772);
                double meter = CurrentVM.CurrentModel.Bl.GetDistanceBetweenPoints(estimates[0], fall.CoordinateF);
                if (meter / 1000 <= successSlider.Value)
                    NumOfSuccess++;
                else
                    NumOfFailers++;
                //this.dis.Add(meter / 1000);
                //labelsList.Add(fall.DateFall.ToString());//here
            }

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Sucsess",
                    Values = new ChartValues<double> {NumOfSuccess},
                    //DataLabels = true,
                    //LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Failed",
                    Values = new ChartValues<double> {numOfFailers},
                    //DataLabels = true,
                    //LabelPoint = labelPoint
                },

            };

            pieChart1.LegendLocation = LegendLocation.Bottom;

            this.DataContext = this;
            Myfather.shell.Content = this;








           
        }

    }
}
