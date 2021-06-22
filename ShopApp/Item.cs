using System;
namespace ShopApp
{
    public class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public Item(string name, int price)
        {
            Name = name;
            Price = price;
            Quantity = 1;
        }
    }
}
