
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Template.Commands
{
    public class DelegateCommand : ICommand  // 继承 ICommand 接口
    {
        /**************************  接口的实现 *****************************/
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (CanExecuteFunc == null)
            {
                return true;
            }
            return CanExecuteFunc(parameter);
        }

        public void Execute(object parameter)
        {
            if (ExecuteAction == null)
            {
                return;
            }
            ExecuteAction(parameter);
        }

        /**************************  接口的实现 *****************************/

        public Action<object> ExecuteAction;
        public Func<object, bool> CanExecuteFunc;
    }
}
