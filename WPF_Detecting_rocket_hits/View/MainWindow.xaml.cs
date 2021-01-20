using LiveCharts;
using LiveCharts.Wpf;
using PL.View;
using PL.ViewModel;
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

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow AppWindow;


        public MainWindow(TheViewModel viewModel_)
        {
            InitializeComponent();
            //CurrentVM = new TheViewModel();
            CurrentVM = viewModel_;
            this.DataContext = CurrentVM;
            AppWindow = this;
            CurrentVM.FallBtnCom.MyEvent += () => ShowFall();
            CurrentVM.RepBtnCom.MyEvent += () => ShowRep();
            CurrentVM.AnalysisBtnCom.MyEvent += () => ShowGraph();
            CurrentVM.MapsBtnCom.MyEvent += () => ShowMaps();
            this.welcomeTxt.Text += " "+CurrentVM.TheUser.EmailUser;
            ////
            this.reportingBtn.IsEnabled = CurrentVM.TheUser.CellCenter;
            this.fallingBtn.IsEnabled = CurrentVM.TheUser.Analyst;
            this.searchBtn.IsEnabled = CurrentVM.TheUser.Analyst;
            this.analysBtn.IsEnabled = CurrentVM.TheUser.Analyst;
            ////
        }

        private void ShowFall()
        {
            AddFall_ = new AddFall(this);
            this.shell.Content = AddFall_;
        }

        private void ShowRep()
        {
            AddReport_ = new AddReport(this);
            this.shell.Content = AddReport_;
        }

        private void ShowGraph()
        {
            GraphUc = new graphUC(this);
            this.shell.Content = GraphUc;
        }
        private void ShowMaps()
        {
            MapsUc_ = new MapsUC(this);
            this.shell.Content = MapsUc_;
        }

        public TheViewModel CurrentVM { get;  set; }

        public AddReport AddReport_ { get; set; }
        public graphUC GraphUc { get; set; }

        public AddFall AddFall_ { get; set; }

        public MapsUC MapsUc_ { get;  set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login win = new Login();
            win.Show();
            this.Close();
        }

      
    }
}
