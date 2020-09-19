using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Environment
    {
        private int temp;

        public Environment() { }

        public Environment(int temp)
        {
            this.temp = temp;
        }

        public int GetTemp()
        {
            return temp;
        }

        public override string ToString()
        {
            return Convert.ToString(temp);
        }
    }
}
