﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client : User
    {
        public Client(string name, string login, string password) : base(name, login, password) { }
    }
}
