using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Instruments
    {
        private string name;
        private int count;

        public Instruments(string name, int count)
        {
            this.name = name;
            this.count = count;
        }
        public string getName()
        {
            return name;
        }
        public int getCount()
        {
            return count;
        }
    }
}
