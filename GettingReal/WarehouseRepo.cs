using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GettingReal
{
    public class WarehouseRepo
    {
        private List<Product> productList = new List<Product>();

        public void TestItems()
        {
            //***Test Items***
            productList = new List<Product>
           {
               new Product("Hvid Maling"),
               new Product("Grå Maling"),
               new Product("Beige Maling"),
               new Product("Gul Maling"),
               new Product("Rød Maling")
           };
        }

        public void ProductList()
        {
            TestItems();
            int count = 0;

            foreach(Product obj in productList)
            {
                count++;
                Console.WriteLine(obj);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Antal af forskellige varer: {count}");
        }
        public void SetNewProduct(string productName, int quantity, double price)
        {
            //Save to localDB method hasn't been implemented yet
            if (productName == "42")
            {
                Console.WriteLine("Ny vare er blevet oprettet.");
                Console.WriteLine("Vare: " + productName +" "+ "Antal: " + quantity+" " + "Pris: " + price);
                Confirm();
            }
            else
            {
                Console.WriteLine("Der skete en fejl!");
                Console.WriteLine("Varen blev ikke oprettet.");
                Console.WriteLine("Vare: " + productName);
            }
        }

        public Boolean Confirm()
        {            
            Console.WriteLine("Er det korrekt?");
            Console.WriteLine("1: Ja");
            Console.WriteLine("2: Nej");
            string confirm = Console.ReadLine();
            if (confirm == "1")
            {
                Console.WriteLine("Varen blev oprettet");
                return true;

            }
            else if (confirm == "2")
            {
                Console.WriteLine("Varen blev slettet");
                return false;                
            }

            bool.TryParse(confirm, out bool result);
            return result;
        }
    }
}
