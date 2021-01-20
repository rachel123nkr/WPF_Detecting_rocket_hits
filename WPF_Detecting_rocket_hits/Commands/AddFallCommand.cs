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
    public class AddFallCommand : ICommand
    {
         private IFallViewModel CurrentVM;

        event EventHandler ICommand.CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public AddFallCommand()
        {

        }

        public AddFallCommand(IFallViewModel vm)
        {
            CurrentVM = vm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           
                bool value = true;
                bool ok = bool.TryParse(parameter.ToString(), out value);
                if (ok)
                {
                    if (value)
                        CurrentVM.AddNewFallWithAddress();
                    else
                        CurrentVM.AddNewFallWithImage();
                }
           
            
            
        }
    }
}
