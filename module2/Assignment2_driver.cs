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
}