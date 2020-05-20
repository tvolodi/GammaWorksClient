using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace GammaWorksClient.Shared.UiTool
{
    public class RelayCommand : ICommand
    {
        private readonly Action action;
        private readonly Func<bool> canExecute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action action, Func<bool> canExecute)
        {
            if (action == null) throw new ArgumentNullException("action");
            this.action = action;
            this.canExecute = canExecute;
        }

        public RelayCommand(Action action) : this(action, null) {}

        public bool CanExecute(object parameter)
        {
            bool result = canExecute == null ? true : canExecute();
            return result;
        }

        public void Execute(object parameter)
        {
            action();
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if(handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}
