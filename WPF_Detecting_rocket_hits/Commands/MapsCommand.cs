using PL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PL.Commands
{
    public class MapsCommand:ICommand
    {

        public delegate void MyEventAction();
        public event MyEventAction MyEvent;

        private IReportViewModel CurrentVM;

        event EventHandler ICommand.CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public MapsCommand()
        {

        }

        public MapsCommand(TheViewModel vm)
        {
            CurrentVM = vm;
        }

        bool ICommand.CanExecute(object parameter)
        {
            return true;
        }

        void ICommand.Execute(object parameter)
        {
            
            //CurrentVM.showReportForm();
            MyEvent?.Invoke();

        }
    }
}
