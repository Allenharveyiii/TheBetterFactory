using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterFactory
{
    class Inventory
    {
        public List<Item> ItemInventory { get; private set; }

        private void SetItemInventory(List<Item> ItemInventory) => this.ItemInventory = ItemInventory;
        public Inventory() => this.SetItemInventory(new List<Item>());

        public void AddItem(Item item)
        {
            if (ItemInventory.Exists(x => x.Name == item.Name))
            {
                //Gets item and increases the quantity by the quantity 
                //of the newly added item instead of adding duplicate item.
                (ItemInventory.ElementAt(ItemInventory.IndexOf(ItemInventory.Find(y => y.Name == item.Name)))).IncreaseQuantity(item);
            }
            else
            {
                ItemInventory.Add(item);
            }
        }
        //Removes an item from the inventory
        //or decreases quantity by given amount
        public void RemoveItem(String item, int Quantity)
        {
            if (ItemInventory.Contains(ItemInventory.Find(y => y.Name == item)))
            {
                Item i = ItemInventory.Find(y => y.Name == item);
                int quant = (ItemInventory.ElementAt(ItemInventory.IndexOf(i)).Quantity - Quantity);
                if (quant > 0)
                {
                    i.DecreaseQuantity(Quantity);
                }
                else if (quant == 0)
                {
                    ItemInventory.Remove(i);
                }
                else
                {
                    Console.WriteLine("Not enough quantity in item to decrease by given quantity... Removing Item");
                    ItemInventory.Remove(i);
                }
            }
            else
            {
                throw new System.Exception();
            }
        }

        public StringBuilder PrintInventory()
        {
            StringBuilder InventoryOutput = new StringBuilder();
            foreach (Item item in this.ItemInventory)
            {
                InventoryOutput.Append(item.Name);
                InventoryOutput.Append(" ");
                InventoryOutput.AppendLine("" + item.Quantity);
            }
            return InventoryOutput;
        }

    }
}
