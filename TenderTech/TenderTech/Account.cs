using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenderTech
{
    static public class Account
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

        static public string uID
        {
            get;

            private set;
        }

        static private string uLogin
        {
            get;

            set;
        }

        static private string uPass
        {
            get;

            set;
        }

        static public string Auth()
        {
            if (SQL.Login(uLogin, uPass) == uPass)
            {
                return uID;
            }
            else
            {
                return "Error";
            }
        }

        static public string Reg()
        {
            SQL.Register(uLogin, uPass, uID);
            return uID;
        }

        static public void Delete(string id)
        {
            SQL.Delete(id);
        }
    }
}
