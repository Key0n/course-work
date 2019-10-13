using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPZ
{
    [Serializable]
    public class Account
    {
        string _Name;
        string _Email;
        string _Password;
        string _Note;

        public Account()
        {
        }

        public Account(string name, string email, string password, string note)
        {
            _Name = name;
            _Email = email;
            _Password = password;
            _Note = note;
        }

        public string Name()
        {
            return _Name;
        }

        public string Email()
        {
            return _Email;
        }

        public string Password()
        {
            return _Password;
        }

        public string Note()
        {
            return _Note;
        }
    }
}
