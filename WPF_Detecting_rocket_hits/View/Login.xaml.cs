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

namespace PL.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        internal TheViewModel CurrentVM { get; set; }
        public Login()
        {
            InitializeComponent();
            CurrentVM = new TheViewModel();
            this.DataContext = CurrentVM;
        }

        private void LOGIN_Click(object sender, RoutedEventArgs e)
        {
            var email = this.email_login.Text;
            var pass = this.password_login.Password.ToString();

            try
            {
                var user = CurrentVM.CurrentModel.Bl.GetUser(email, pass);
                CurrentVM.TheUser = user;
                MainWindow win = new MainWindow(CurrentVM);
                win.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                TextInDialog.Text = ex.Message;
                dialogBox.IsOpen = true;
               // MessageBox.Show(ex.Message);
                this.email_login.Clear();
                this.password_login.Clear();
            }

            

        }

        private void SIGN_UP_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var email = this.email_submit.Text;
                var pass = this.password_submit.Password.ToString();
                bool? call = this.call_center.IsChecked;
                if (call == null)
                    call = false;
                bool? anal = this.analyst.IsChecked;
                if (anal == null)
                    anal = false;
                CurrentVM.CurrentModel.Bl.AddUser(new BE.User(email, pass, (bool)call, (bool)anal));
                this.email_submit.Clear();
                this.password_submit.Clear();
                this.call_center.IsChecked = false;
                this.analyst.IsChecked = false;
            }
            catch (Exception ex)
            {
                TextInDialog.Text = ex.Message;
                dialogBox.IsOpen = true;
                
            }
            //MessageBox.Show("enter Success");
            // MainWindow win = new MainWindow(CurrentVM);
            // win.Show();
            //this.Close();
        }
    }
}
