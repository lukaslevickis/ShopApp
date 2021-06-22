using System;

namespace ShopApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string command = string.Empty;
            Customer customer = new Customer();
            Shop shop = new Shop();
            Item candy = new Item("Candy", 4);
            Item book = new Item("Book", 8);
            Item juice = new Item("Juice", 2);

            while (command != "Exit")
            {
                if (command.Contains("book"))
                {
                    shop.UpdateQuantity(command, book);
                    customer.Buy(book);
                }
                else if (command.Contains("candy"))
                {
                    shop.UpdateQuantity(command, candy);
                    customer.Buy(candy);
                }
                else if (command.Contains("juice"))
                {
                    shop.UpdateQuantity(command, juice);
                    customer.Buy(juice);
                }
                else if (command.Contains("Topup"))
                {
                    customer.Topup(command);
                }

                Console.WriteLine("Type 'Exit' if you want to exit or Buy or Topup");
                command = Console.ReadLine();
            }
        }
    }
}
