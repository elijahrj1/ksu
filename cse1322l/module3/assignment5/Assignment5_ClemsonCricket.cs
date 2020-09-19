using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class ClemsonCricket : Cricket
    {
        public ClemsonCricket() : base() { }

        public new int GetChirpCount(Environment place)
        {
            int original = base.GetChirpCount(place);
            return original - ((original * 20) / 100); 
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
