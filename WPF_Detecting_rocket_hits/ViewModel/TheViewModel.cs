using BE;
using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.Win32;
using PL.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace PL.ViewModel
{
    public class TheViewModel : INotifyPropertyChanged, IReportViewModel, IFallViewModel, IGrahpsViewModel
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

        private Model.Model currentModel;
        public Model.Model CurrentModel
        {
            get { return currentModel; }
            set
            {
                currentModel = value;

            }
        }

        public AddReportCommand AddRepCom { get; set; }//the butten of finish

        public AddFallCommand AddFallCom { get; set; }//the butten of finish

        public ReportBtnCommand RepBtnCom { get; set; }//the butten in the menu
        public FallBtnCommand FallBtnCom { get; set; }//the butten in the menu
        public MapsCommand MapsBtnCom { get; set; }//the butten in the menu

        private GraphsCommand analysisBtnCom;
        public GraphsCommand AnalysisBtnCom
        {
            get { return analysisBtnCom; }
            set
            {
                analysisBtnCom = value;
                OnPropertyChanged("AnalysisBtnCom");
            }
        }//the butten in the menu

        public loadImageCommand loadCom { get; set; }//the butten load

        public BE.User TheUser
        {
            get { return CurrentModel.CurUser; }
            set
            {
                CurrentModel.CurUser = value;
                OnPropertyChanged("TheUser");
            }
        }

        public BE.ReportFall TheReportFall
        {
            get { return CurrentModel.CurRepFall; }
            set
            {
                CurrentModel.CurRepFall = value;
                OnPropertyChanged("TheReportFall");
            }
        }

        public BE.Fall TheFall
        {
            get { return CurrentModel.CurFall; }
            set
            {
                CurrentModel.CurFall = value;
                OnPropertyChanged("TheFall");
            }
        }

        public TheViewModel()
        {
            CurrentModel = new Model.Model();
            TheFall = CurrentModel.CurFall;
            TheReportFall = CurrentModel.CurRepFall;
            TheUser = CurrentModel.CurUser;
            AddRepCom = new AddReportCommand(this);
            AddFallCom = new AddFallCommand(this);
            RepBtnCom = new ReportBtnCommand(this);
            FallBtnCom = new FallBtnCommand(this);
            loadCom = new loadImageCommand(this);
            AnalysisBtnCom = new GraphsCommand(this);
            MapsBtnCom = new MapsCommand(this);

        }


        public void AddNewReport()
        {
            try
            {
                CurrentModel.CurRepFall.CoordinateR = CurrentModel.Bl.GetCoordinate(CurrentModel.CurRepFall.City, CurrentModel.CurRepFall.Address);
                CurrentModel.Bl.AddReportFall(CurrentModel.CurRepFall);
                TheReportFall = new ReportFall();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void AddNewFallWithAddress()
        {
            try
            {
                CurrentModel.CurFall.CoordinateF = CurrentModel.Bl.GetCoordinate(CurrentModel.CurFall.CityFall, CurrentModel.CurFall.AddressFall);
                // CurrentModel.CurFall.CoordinateF = CurrentModel.Bl.getImageCoordinate(CurrentModel.CurFall.ImageLocation);
                CurrentModel.Bl.AddFall(CurrentModel.CurFall);
                TheFall = new Fall();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void AddNewFallWithImage()
        {
            try
            {
                CurrentModel.CurFall.CoordinateF = CurrentModel.Bl.getImageCoordinate(CurrentModel.CurFall.ImageLocation.ToString());
                CurrentModel.Bl.AddFall(CurrentModel.CurFall);
                TheFall = new Fall();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //not used
        public void showReportForm()
        {

            //PL.MainWindow.AppWindow.shell.Visibility = System.Windows.Visibility.Visible;

            // PL.MainWindow.AppWindow.graphShell.Visibility = System.Windows.Visibility.Hidden;
            // PL.MainWindow.AppWindow.fallShell.Visibility = System.Windows.Visibility.Hidden;
            //PL.MainWindow.AppWindow.repShell.Visibility = System.Windows.Visibility.Visible;
            //addRepEvent?.Invoke();
        }

        //not used
        public void showFallFrom()
        {
            //PL.MainWindow.AppWindow.shell.Visibility = System.Windows.Visibility.Visible;

            //PL.MainWindow.AppWindow.graphShell.Visibility = System.Windows.Visibility.Hidden;
            //PL.MainWindow.AppWindow.repShell.Visibility = System.Windows.Visibility.Hidden;
            //PL.MainWindow.AppWindow.fallShell.Visibility = System.Windows.Visibility.Visible;
        }
        //not used
        public double showGraphFrom()
        {
            //ReportFall[] ReportToEstimate = CurrentModel.Bl.GetReportBetweenTime(DateTime.Now);
            //Coordinate[] estimates = CurrentModel.CurKmeans.returnAvgPerGroupFromRep(ReportToEstimate);
            //Coordinate fall1 = new Coordinate(32.0523655, 34.815199277777772);
            //double meter = CurrentModel.Bl.GetDistanceBetweenPoints(estimates[0], fall1);
            //return meter;


            // graphEvent?.Invoke(meter);
            return 0;
        }

        public void loadImg()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                //PL.MainWindow.AppWindow.fallShell.ImageFall.Source = new BitmapImage(new Uri(op.FileName));
                TheFall.ImageLocation = op.FileName;
                OnPropertyChanged("TheFall");
                CurrentModel.CurFall.ImageLocation = op.FileName;

                // MessageBox.Show(PL.MainWindow.AppWindow.fallShell.ImageFall.Source);
            }
        }




    }


}
