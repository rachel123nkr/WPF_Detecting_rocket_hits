using BE;
using Microsoft.Maps.MapControl.WPF;
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
    /// Interaction logic for MapsUC.xaml
    /// </summary>
    public partial class MapsUC : UserControl, INotifyPropertyChanged
    {
        public MapsUC(MainWindow father)
        {
            InitializeComponent();
            Myfather = father;
            CurrentVM = (TheViewModel)father.DataContext;
            this.DataContext = this;

            //Set map to Aerial mode with labels
            myMap.Mode = new AerialMode(true);
            //FallList = new List<BE.Fall>();
            // FallsComboBox.ItemsSource = FallList;
            // this.FallsComboBox.DisplayMemberPath = "TheFall.FallId";
            //this.FallsComboBox.SelectedValuePath = "TheFall.FallId";
        }

        private List<BE.Fall> fallList;

        public List<BE.Fall> FallList
        {
            get { return fallList; }
            set
            {
                fallList = value;
                OnPropertyChanged("fallList");
            }
        }

        //private List<BE.ReportFall> reportList;
        //public List<BE.ReportFall> ReportList
        //{
        //    get { return reportList; }
        //    set
        //    {
        //        reportList = value;
        //        OnPropertyChanged("reportList");

        //    }
        //}
        public MainWindow Myfather { get; private set; }
        public TheViewModel CurrentVM { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            try { 
            this.NoReprtTxt.Visibility = Visibility.Collapsed;
            this.buttonHow.Visibility = Visibility.Collapsed;
            this.page.Visibility = Visibility.Collapsed;
            this.realFallPin.Visibility = Visibility.Collapsed;
            this.theEstimatePin.Visibility = Visibility.Collapsed;
            this.MapPolyline.Visibility = Visibility.Collapsed;



            var datePicker = ((DatePicker)sender);
            setToTheList(datePicker.SelectedDate);
            if (this.FallsComboBox.Items.Count == 0)
            {
                this.NoReprtTxt.Visibility = Visibility.Visible;
                return;
            }
            this.FallsComboBox.IsDropDownOpen = true;

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

              try { 
            this.NoReprtTxt.Visibility = Visibility.Collapsed;
            this.buttonHow.Visibility = Visibility.Collapsed;
            this.page.Visibility = Visibility.Collapsed;
            this.realFallPin.Visibility = Visibility.Collapsed;
            this.theEstimatePin.Visibility = Visibility.Collapsed;
            this.MapPolyline.Visibility = Visibility.Collapsed;



            var datePicker = ((DatePicker)sender);
            setToTheList(datePicker.SelectedDate);
            if (this.FallsComboBox.Items.Count == 0)
            {
                this.NoReprtTxt.Visibility = Visibility.Visible;
                return;
            }
            this.FallsComboBox.IsDropDownOpen = true;

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

}

        private void setToTheList(DateTime? date)
        {
            if (date == null)
                return;
            FallList = CurrentVM.CurrentModel.Bl.FallAcordDate((DateTime)date);
        }


        private void FallsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                this.NoReprtTxt.Visibility = Visibility.Collapsed;
                this.buttonHow.Visibility = Visibility.Collapsed;
                this.page.Visibility = Visibility.Collapsed;
                this.realFallPin.Visibility = Visibility.Collapsed;
                this.theEstimatePin.Visibility = Visibility.Collapsed;
                this.MapPolyline.Visibility = Visibility.Collapsed;

                object selctionValue = this.FallsComboBox.SelectedValue;
                if (selctionValue == null)
                    return;
                var fall = CurrentVM.CurrentModel.Bl.GetFallById(int.Parse(selctionValue.ToString()));

                Coordinate theFallPoint = fall.CoordinateF;

                var ReportList = CurrentVM.CurrentModel.Bl.GetReportBetweenTime(fall.DateFall);

                if (ReportList.Length == 0)//if there is't report
                {
                    showReaFallPin(theFallPoint);
                    this.NoReprtTxt.Visibility = Visibility.Visible;
                    return;
                }

                var EstimateL = CurrentVM.CurrentModel.Bl.GetKMeans().returnAvgPerGroupFromRep(ReportList);

                if (EstimateL.Length == 0)//if there is't report
                {
                    showReaFallPin(theFallPoint);
                    this.NoReprtTxt.Visibility = Visibility.Visible;
                    return;
                }


                this.buttonHow.Visibility = Visibility.Visible;

                showReaFallPin(theFallPoint);

                Coordinate theEstimatePoint = EstimateL[0];
                this.theEstimatePin.Location = new Location(theEstimatePoint.Latitude, theEstimatePoint.Longitude);
                this.theEstimatePin.Visibility = Visibility.Visible;
                this.MapPolyline.Visibility = Visibility.Visible;
                this.MapPolyline.Locations = new LocationCollection() { this.theEstimatePin.Location, this.realFallPin.Location };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showReaFallPin(Coordinate theFallPoint)
        {
            this.realFallPin.Location = new Location(theFallPoint.Latitude, theFallPoint.Longitude);
            this.realFallPin.Visibility = Visibility.Visible;
            this.myMap.Center = this.realFallPin.Location;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.page.Visibility = Visibility.Visible;
                showReportToFall uc = new showReportToFall();
                var fall = CurrentVM.CurrentModel.Bl.GetFallById(int.Parse(this.FallsComboBox.SelectedValue.ToString()));
                var ReportList = CurrentVM.CurrentModel.Bl.GetReportBetweenTime(fall.DateFall);
                uc.Source = ReportList;
                this.page.Content = uc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
