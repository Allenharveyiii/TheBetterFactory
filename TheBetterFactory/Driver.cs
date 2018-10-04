using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterFactory
{
    class Driver
    {
        public static void Main(string[] args)
        {
            List<Item> Items = new List<Item>
            {
                new Item("Cardboard", 1),
                new Item("Metal", 1),
                new Item("Plastic", 1),
                new Item("Cardboard", 1),
                new Item("Metal", 37)
            };

            Inventory ItemInv = new Inventory();

            foreach (Item item in Items)
            {
                ItemInv.AddItem(item);
            }
            Console.WriteLine(ItemInv.PrintInventory());

            ItemInv.RemoveItem("Cardboard", 2);
            Console.Write("\n");
            Console.WriteLine(ItemInv.PrintInventory());
        }
    }
}
