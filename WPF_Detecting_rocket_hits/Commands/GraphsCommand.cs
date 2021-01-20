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
    public class GraphsCommand : ICommand
    {
        private IGrahpsViewModel CurrentVM;

        public delegate void MyEventAction();
        public event MyEventAction MyEvent;
       

        event EventHandler ICommand.CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public GraphsCommand()
        {

        }

        public GraphsCommand(IGrahpsViewModel vm)
        {
            CurrentVM = vm;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           
           // double m=CurrentVM.showGraphFrom();
            MyEvent?.Invoke();

        }
    }
}
