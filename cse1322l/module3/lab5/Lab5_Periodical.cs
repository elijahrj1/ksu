using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Periodical : Item
    {
        private int issueNum;

        public Periodical() : base() { }

        public Periodical(string title, int issueNum) : base(title)
        {
            this.issueNum = issueNum;
        }

        public int GetIssueNum()
        {
            return issueNum;
        }

        public override string GetListing()
        {
            return "Periodical Title: " + this.GetTitle() + "\nIssue: #" + this.GetIssueNum();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
