using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_03_03_Пироговський.Classes
{
    internal class LogIn
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public LogIn(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool ValidateCredentials(string username, string password)
        {
            return Username == username && Password == password;
        } 
    }
}
