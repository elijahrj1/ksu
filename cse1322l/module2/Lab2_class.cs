using System;

namespace Lab2
{
    class StockItem
    {
        private static int count = 1;
        private string description;
        private int ID = 100000;
        private int amount = 0;
        private double price;

        public StockItem()
        {
            SetDescription("");
            AddAmount(0);
            SetPrice(0.0);
            ID = count++;
        }

        public StockItem(string description, int amount, double price)
        {
            SetDescription(description);
            AddAmount(amount);
            SetPrice(price);
            ID = count++;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public void SetPrice(double price)
        {
            this.price = price;

        }

        public void AddAmount(int amount)
        {
            this.amount += amount;
        }

        public void RemoveAmount(int amount)
        { 
            this.amount -= amount;
        }

        public string GetDescription()
        {
            return description;
        }

        public int GetAmount()
        {
            return amount;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetID()
        {
            return ID;
        }

        public override string ToString()
        {
            string s = 
                "\nDescription: " + GetDescription() +
                "\nID: " + GetID() +
                "\nAmount: " + GetAmount() +
                "\nPrice: " + GetPrice() +
                "\n";
            return s; 
        }
    }
}
