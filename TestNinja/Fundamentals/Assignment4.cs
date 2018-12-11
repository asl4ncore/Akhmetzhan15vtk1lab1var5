using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment4
    {
        private string _login;
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }
        /// <summary>
        /// Функция получает имя и фамилию и  сохраняет их.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        public void CreateUser(string login, string password)
        {
            _login = login;
            _password =  password;
        }

        public string DisplayPassForAdmin(string password)
        {
            return _password;
        }

    }
}
