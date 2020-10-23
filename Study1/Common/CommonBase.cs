using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Study1.Common
{
    public class CommonBase : ICommand /*引用接口，来操控界面（个人理解）*/
    {
        public event EventHandler CanExecuteChanged; /*事件*/

        public bool CanExecute(object parameter) /*判断是否可执行，逻辑判断*/
        {
            return DoCanExcute?.Invoke(parameter) == true;
        }

        public void Execute(object parameter) /*执行体*/
        {
            DoExcute?.Invoke(parameter);
        }
        public Action<object> DoExcute { get; set; }
        public Func<object,bool> DoCanExcute { get; set; }
    }
}
