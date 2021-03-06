﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment5
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
            if (login.ToLower()=="admin")
                throw new ArgumentException();
            _login = login;
            _password = password;
        }

    }
}
