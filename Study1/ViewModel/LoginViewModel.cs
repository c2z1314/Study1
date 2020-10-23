using Study1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Study1.ViewModel
{
    public class LoginViewModel
    {
        public CommonBase CloseWindowCommand { get; set; }

        public LoginViewModel()
        {
            this.CloseWindowCommand = new CommonBase();
            this.CloseWindowCommand.DoExcute = new Action<object>((o) =>
              {
                  (o as Window).Close();
              });
            this.CloseWindowCommand.DoCanExcute = new Func<object, bool>((o) => { return true; });
        }
    }
}
