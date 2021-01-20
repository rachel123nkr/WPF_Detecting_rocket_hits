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
    public class loadImageCommand : ICommand
    {
        

        private IFallViewModel CurrentVM;

        event EventHandler ICommand.CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public loadImageCommand()
        {

        }

        public loadImageCommand(IFallViewModel vm)
        {
            CurrentVM = vm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           
            CurrentVM.loadImg();
        }
    }
}
