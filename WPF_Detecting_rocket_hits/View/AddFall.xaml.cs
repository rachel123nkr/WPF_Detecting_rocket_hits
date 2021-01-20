using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PL.View
{
    /// <summary>
    /// Interaction logic for AddFall.xaml
    /// </summary>
    public partial class AddFall : UserControl
    {
        internal IFallViewModel CurrentVM { get; set; }
        public MainWindow Myfather { get; set; }


        public AddFall(MainWindow father)
        {
            InitializeComponent();
            Myfather = father;
            CurrentVM = (TheViewModel)father.DataContext;
            //CurrentVM =(IFallViewModel) this.DataContext;
            //CurrentVM = new TheViewModel();
            //this.DataContext = CurrentVM;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.imgLab.Visibility = Visibility.Visible;
            this.imgStack.Visibility = Visibility.Visible;
            this.StreetFall.Visibility = Visibility.Collapsed;
            this.cityFall.Visibility = Visibility.Collapsed;
            this.streetLab.Visibility = Visibility.Collapsed;
            this.cityLab.Visibility = Visibility.Collapsed;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(this.ImageFall.Source.ToString());
            this.imgLab.Visibility = Visibility.Collapsed;
            this.imgStack.Visibility = Visibility.Collapsed;
            this.StreetFall.Visibility = Visibility.Visible;
            this.cityFall.Visibility = Visibility.Visible;
            this.streetLab.Visibility = Visibility.Visible;
            this.cityLab.Visibility = Visibility.Visible;
        }
    }
}
