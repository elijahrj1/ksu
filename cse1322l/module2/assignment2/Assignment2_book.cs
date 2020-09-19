using System;

namespace Assignment2
{
	public class Book
    {
        private string id = "";
        private bool check = true;
        private string dueDate = "";
        private string author = "";
        private string title = "";
        private string genre = "";
        private int pages = 0;
        private int minDaysOnHold = 0;

        public Book() { }

        public Book(string id, bool check, string dueDate, string title, string author, string genre, int pages, int minDaysOnHold)
        {
            SetId(id);
            SetCheck(check);
            SetDueDate(dueDate);
            SetTitle(title);
            SetAuthor(author);
            SetGenre(genre);
            SetPages(pages);
            SetMinDaysOnHold(minDaysOnHold);
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetDueDate()
        {
            return dueDate;
        }

        public string GetGenre()
        {
            return genre;
        }

        public string GetId()
        {
            return id;
        }

        public int GetMinDaysOnHold()
        {
            return minDaysOnHold;
        }

        public int GetPages()
        {
            return pages;
        }

        public string GetTitle()
        {
            return title;
        }

        public bool GetCheck()
        {
            return check;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public void SetCheck(bool check)
        {
            this.check = check;
        }

        public void SetDueDate(string dueDate2)
        {
            this.dueDate = dueDate2;
        }

        public void SetGenre(string genre)
        {
            this.genre = genre;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public void SetMinDaysOnHold(int minDaysOnHold)
        {
            this.minDaysOnHold = minDaysOnHold;
        }

        public void SetPages(int pages)
        {
            this.pages = pages;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public bool PutOnHold(string author, string genre, string title, int noOfDaysOnHold)
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
            return "Id: " + this.GetId() + "\n" +
                    "Title: " + this.GetTitle() + "\r\n" +
                    "Checked In: " + this.GetCheck() + "\r\n" +
                    "Author: " + this.GetAuthor() +
                    "\r\nGenre: " + this.GetGenre() +
                    "\r\nPages: " + this.GetPages();
        }
    }
}