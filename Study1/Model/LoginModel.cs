using Study1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Study1.Model
{
    public class LoginModel: NotifyBase //需要继承Common类，用来通知。
    {
        private string _userName;
        public string UserName //用户名的实体层 
        {
            get { return _userName; }
            set {
                _userName = value;
                this.DoNotify();
            }
        }

        private string _password;
        public string Password //密码的实体层
        {
            get { return _password; }
            set
            {
                _password = value;
                this.DoNotify();
            }
        }

        private string _verificationCode;
        public string VerificationCode //验证码的实体层
        {
            get { return _verificationCode; } 
            set
            {
                _verificationCode = value;
                this.DoNotify();
            }
        }
    }
}
