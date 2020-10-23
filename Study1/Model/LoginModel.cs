using Study1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Study1.Model
{
    public class LoginModel: NotifyBase
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set {
                _userName = value;
                this.DoNotify();
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                this.DoNotify();
            }
        }

        private string _verificationCode;
        public string VerificationCode
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
