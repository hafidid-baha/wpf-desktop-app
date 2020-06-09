using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library
{
    class RelyCommand : ICommand
    {
        #region Private Member

        public Action mAction;

        #endregion

        #region Constructor
        public RelyCommand(Action action)
        {
            mAction = action;

        }
        #endregion

        public event EventHandler CanExecuteChanged = (sender,e) => { };

        #region Command Method
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mAction();
        }

        #endregion
    }
}
