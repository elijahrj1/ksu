using System;

namespace Lab5
{
    class MyCollection
    {
        static void Main(string[] args)
        {
            Item[] items = new Item[5];
            items[0] = new Book("Lord of the Rings", "Tolkien", "1234");
            items[1] = new Periodical("Times", 34);
            items[2] = new Book("War And Peace", "Tolstoy", "4657");
            items[3] = new Book("Alice in Wonderland", "Lewis Carroll", "7890");
            items[4] = new Periodical("New Yorker", 45);

            for(int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i].GetListing()); // look at that polymorphism in action!!
                Console.WriteLine();
            }
        }
    }
}
