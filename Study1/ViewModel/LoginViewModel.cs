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
    public class LoginViewModel :NotifyBase
    {
        public LoginModel LoginModel { get; set; } = new LoginModel();
        public CommonBase CloseWindowCommand { get; set; }
        public CommonBase LoginCommond { get; set; }
        private string _errMessage;
        public string  ErroMessage
        {
            get { return _errMessage; }
            set { _errMessage = value; this.DoNotify(); }
        }

        public LoginViewModel()
        {
            //this.LoginMode = new LoginModel
            //{
            //    UserName = "gdc",
            //    VerificationCode = "233",
            //    Password = "1"
            //};

            this.CloseWindowCommand = new CommonBase();
            this.CloseWindowCommand.DoExcute = new Action<object>((o) =>
              {
                  (o as Window).Close();
              });
            this.CloseWindowCommand.DoCanExcute = new Func<object, bool>((o) => { return true; });

            this.LoginCommond = new CommonBase();
            this.LoginCommond.DoExcute = new Action<object>(DoLogin); //委托
            this.LoginCommond.DoCanExcute = new Func<object, bool>((o) => { return true; });
        }
        private void DoLogin(object o)
        {//有专门表单验证的库，比较少，所以用这种方式判断。
            if (string.IsNullOrEmpty(LoginModel.UserName))
            {
                this.ErroMessage = "请输入用户名！";
                return; //如果没有输入用户名的话就不执行下面的判断了。
            }

            if (string.IsNullOrEmpty(LoginModel.Password))
            {
                this.ErroMessage = "请输入密码！";
                return;
            }

            if (string.IsNullOrEmpty(LoginModel.VerificationCode))
            {
                this.ErroMessage = "请输入验证码！";
                return;
            }

            if (LoginModel.VerificationCode.ToLower() != "vmo4")
            {
                this.ErroMessage = "验证码错误！";
                return;
            }


        }
    }
}
