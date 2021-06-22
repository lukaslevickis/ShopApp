using System;
namespace ShopApp
{
    public class Customer
    {
        private decimal wallet = 10;

        public void Buy(Item item)
        {
            decimal amount = item.Price * item.Quantity;
            if (amount < wallet)
            {
                wallet -= amount;
                Console.WriteLine(item.Name + " bought");
            }
            else if (item.Price > wallet)
            {
                Console.WriteLine("Not enough money");
            }
        }

        public void Topup(string amount)
        {
            string[] amountFromString = amount.Split(' ');
            wallet += decimal.Parse(amountFromString[1]);
            Console.WriteLine("Wallet amount - " + wallet);
        }
    }
}
