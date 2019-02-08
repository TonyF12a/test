using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenderTech
{
    public class Account
    {
        public int uID
        {
            get
            {
                return uID;
            }

            private set
            {
                uID = value;
            }
        }

        private string uLogin
        {
            get
            {
                return uLogin;
            }

            set
            {
                uLogin = value;
            }
        }

        private string uPass
        {
            get
            {
                return uPass;
            }

            set
            {
                uPass = new Crypt().Encrypt(value);
            }
        }

        public int Auth(string login, string pass)
        {


            return 1;
        }
    }
}
