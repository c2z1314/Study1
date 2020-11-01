using Study1.Common;
using Study1.Model;
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
        public LoginModel LoginMode { get; set; }
        public CommonBase CloseWindowCommand { get; set; }

        public LoginViewModel()
        {
            this.LoginMode = new LoginModel
            {
                UserName = "gdc",
                VerificationCode = "233",
                Password="1"
            };

            this.CloseWindowCommand = new CommonBase();
            this.CloseWindowCommand.DoExcute = new Action<object>((o) =>
              {
                  (o as Window).Close();
              });
            this.CloseWindowCommand.DoCanExcute = new Func<object, bool>((o) => { return true; });

    }
    }
}
