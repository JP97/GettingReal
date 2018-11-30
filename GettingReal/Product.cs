using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Product
    {
        private string itemName;
        private int inStock;
        private double price;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public int InStock
        {
            get { return inStock; }
            set { inStock = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(string itemName, int inStock, double price)
        {
            ItemName = itemName;
            InStock = inStock;
            Price = price;
        }

        public Product(string itemName, int inStock) :
            this(itemName,inStock, 0)
        {

        }
        public Product(string itemName) :
            this(itemName, 0, 0)
        {

        }

        public override string ToString()
        {
            //Måske hellere bruge en wireframe ala
            //ControlWrite("Vare:" + "Antal:");
            //ConsoleWriteline(ItemName + StockCount);

            string text = "Vare: " + ItemName + " Antal: " + InStock + " Pris: " + price;
            return text;
        }
    }
}
