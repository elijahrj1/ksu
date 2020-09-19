using System;

namespace Assignment2
{
	public class Video
    {
        private string id = "";
        private bool check = true;
        private string dueDate = "";
        private string title = "";
        private string length = "";
        private int minDaysOnHold = 0;


        public Video() { }
         
        public Video(string id, bool check, string dueDate, string title, string length, int minDaysOnHold)
        {
            SetId(id);
            SetCheck(check);
            SetDueDate(dueDate);
            SetLength(length);
            SetMinDaysOnHold(minDaysOnHold);
            SetTitle(title);
        }

        public void SetCheck(bool check)
        {
            this.check = check;
        }

        public void SetDueDate(string dueDate2)
        {
            this.dueDate = dueDate2;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public void SetLength(string length2)
        {
            this.length = length2;
        }

        public void SetMinDaysOnHold(int minDaysOnHold)
        {
            this.minDaysOnHold = minDaysOnHold;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetDueDate()
        {
            return dueDate;
        }

        public string GetId()
        {
            return id;
        }

        public string GetLength()
        {
            return length;
        }

        public int GetMinDaysOnHold()
        {
            return minDaysOnHold;
        }

        public string GetTitle()
        {
            return title;
        }

        public bool GetCheck()
        {
            return this.check;
        }

        public bool PutOnHold(string title, int length, int noOfDaysOnHold)
        {
            if (noOfDaysOnHold <= GetMinDaysOnHold())
            {
                SetCheck(false);

            }
            else
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return "Id:" + this.GetId() + "\n" +
                    "Title: " + this.GetTitle() + "\r\n" +
                    "Checked In: " + this.GetCheck() + "\r\n" +
                    "Length: " + this.GetLength();


        }
    }
}