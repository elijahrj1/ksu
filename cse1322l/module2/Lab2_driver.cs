using System;

namespace Lab2
{
    class StockItemDriver
    {
        static void Main(string[] args)
        {
            StockItem stock = new StockItem();
            Console.Write("Enter Description: ");
            stock.SetDescription(Console.ReadLine());
            Console.Write("Enter Amount: ");
            stock.AddAmount(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter Price: ");
            stock.SetPrice(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(stock);
            Console.Write("Enter Amount To Remove: ");
            stock.RemoveAmount(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Final: \n" + stock);
        }
    }
}
