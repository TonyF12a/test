using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenderTech
{
    public class Account
    {
        public Account(string login, string pass)
        {
            uLogin = login;
            uPass = new Crypt().Encrypt(pass);
            char[] values = uLogin.ToCharArray();
            string id = "";
            foreach (char letter in values)
            {
                string value = Convert.ToInt32(letter).ToString();
                id += value;
            }
            uID = id;
        }

        public string uID
        {
            get;

            private set;
        }

        private string uLogin
        {
            get;

            set;
        }

        private string uPass
        {
            get;

            set;
        }

        public string Auth()
        {


            return "a";
        }
        
        public string Reg()
        {
            SQL.Register(uLogin, uPass, uID);
            return uID;
        }
    }
}
