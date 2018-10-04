using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterFactory
{
    class Item
    {
        public String Name { get; private set; }
        public int Quantity { get; private set; }
        public int PurchasePrice { get; private set; }
        public int SalePrice { get; private set; }
        //public String MaterialsNeeded { get; private set; }

        private void SetName(string Name) => this.Name = Name;
        private void SetPurchasePrice(int PurchasePrice) => this.PurchasePrice = PurchasePrice;
        private void SetSalePrice(int SalePrice) => this.SalePrice = SalePrice;
        private void SetQuantity(int Quantity) => this.Quantity = Quantity;
        /*private static void SetMaterialsNeeded(string Name){
            this.Name = Name;
        }*/
        public Item(string Name)
        {
            SetName(Name);
            SetPurchasePrice(0);
            SetSalePrice(0);
            SetQuantity(0);
        }

        public Item(string Name, int Quantity)
        {
            SetName(Name);
            SetPurchasePrice(0);
            SetSalePrice(0);
            SetQuantity(Quantity);
        }

        public Item(string Name, int PurchasePrice, int SalePrice, int Quantity)
        {
            SetName(Name);
            SetPurchasePrice(PurchasePrice);
            SetSalePrice(SalePrice);
            SetQuantity(Quantity);
        }
        public void IncreaseQuantity(Item i)
        {
            if (this.Quantity >= 0)
            {
                SetQuantity(this.Quantity + i.Quantity);
            }
        }

        public void DecreaseQuantity(int Quantity) => this.Quantity -= Quantity;

    }

}
