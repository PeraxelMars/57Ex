using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace _57_Exercises.Models
{
    public class Ex15
    {
        private string _userName;
        private string _password;

        public Ex15(string userName, string password)
        {
            _userName = userName;
            _password = Crypto.SHA1(password);
        }

        public bool IsValid()
        {
            Credentials creds = new Credentials();
            var userNameCompare = String.Compare(creds.userName, _userName, StringComparison.OrdinalIgnoreCase);
            var passwordCompare = String.Compare(creds.password, _password, StringComparison.Ordinal);

            return userNameCompare == 0 && passwordCompare == 0;
        }
    }

    public class Credentials
    {
        public string userName = "aaa";
        public string password = Crypto.SHA1("123@Bob");
    }
}