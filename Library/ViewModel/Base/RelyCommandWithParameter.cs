using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library
{
    class RelyCommandWithParameter : ICommand
    {
        #region Private Member
        // Action To Be Execute
        public Action<Object> mAction;

        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor 
        /// </summary>
        /// <param name="action">The Callback Function</param>
        public RelyCommandWithParameter(Action<Object> action)
        {
            mAction = action;

        }
        #endregion

        #region Icommand Event
        public event EventHandler CanExecuteChanged = (sender, e) => { }; 
        #endregion

        #region ICommand Method
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// The Triggered Method 
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            mAction(parameter);
        }

        #endregion
    }
}
