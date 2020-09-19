using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Cricket
    {
        public Cricket() { }

        public int GetChirpCount(Environment place)
        {
            return ((place.GetTemp() * 4) - 40);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
