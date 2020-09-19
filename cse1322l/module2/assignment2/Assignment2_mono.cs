using System;

namespace Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book[] bookData = new Book[5];
            bookData[0] = new Book("234000123", false, "September 3", "Lord of the Rings", "Tolkien", "Fiction", 328, 0);
            bookData[1] = new Book("500012345", true, "September 16", "1984", "Orwell", "Fiction", 328, 12);
            bookData[2] = new Book("555000789", false, "October 8", "Charlotte's Web", "White", "Fiction", 192, 0);
            bookData[3] = new Book("820017895", true, "October 23", "Frankenstein", "Shelley", "Fiction", 280, 7);
            bookData[4] = new Book("513904578", false, "November 2", "The Chronicles of Narnia", "Lewis", "Fiction", 784, 0);

            Video[] videoData = new Video[5];
            videoData[0] = new Video("234000123", false, "September 6", "v1", "8:39", 0);
            videoData[1] = new Video("500012345", false, "September 6", "v2", "6:23", 0);
            videoData[2] = new Video("555000789", true, "September 6", "v3", "12:56", 13);
            videoData[3] = new Video("820017895", false, "September 6", "v4", "2:34", 0);
            videoData[4] = new Video("513904578", false, "September 6", "v5", "1:00", 0);

            //public Video(string id, bool check, string dueDate, string title, string length, int minDaysOnHold)

            for (int i = 0; i < bookData.Length; i++)
            {
                Console.WriteLine("Book Stored " + (i + 1) + "\n" + bookData[i].ToString() + "\n");
            }

            for (int i = 0; i < videoData.Length; i++)
            {
                Console.WriteLine("Video Stored " + (i + 1) + "\n" + videoData[i].ToString() + "\n");
            }
        }
    }

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

    public class Video
    {
        private string id = "";
        private bool check = true;
        private string dueDate = "";
        private string title = "";
        private string length = "";
        private int minDaysOnHold = 0;


        public Video()
        {

        }
         
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
