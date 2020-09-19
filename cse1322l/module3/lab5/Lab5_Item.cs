using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    abstract class Item
    {
        private string title;

        public Item() { }

        public Item(string title)
        {
            this.title = title;
        }

        public abstract string GetListing();

        public string GetTitle()
        {
            return title;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
