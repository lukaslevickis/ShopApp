using System;
namespace ShopApp
{
    public class Shop
    {
        public void UpdateItemQuantity(string command, Item item)
        {
            string[] commandData = command.Split();
            if (commandData.Length > 2)
            {
                item.Quantity = int.Parse(commandData[2]);
            }
        }
    }
}
