using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Controller
    {
        public void ShowProductList()
        {
            Console.WriteLine("-----------------------------");
            WarehouseRepo myStuff = new WarehouseRepo();
            myStuff.ProductList();
            Console.WriteLine("-----------------------------");
            Console.Write("\nTryk på en vilkårlig tast, for at vende tilbage til menuen. . .");
            Console.ReadKey();
            Console.Clear();
        }

        public void RegisterNewProduct()
        {
            do
            {
                Console.WriteLine("-----------------------------");

                Console.Write("Indtast varenavn: ");
                string productName = Console.ReadLine();
                Console.Write("Hvor manger er på lager?");
                string stock = Console.ReadLine();

                int quantity;
                Int32.TryParse(stock, out quantity);

                Console.WriteLine("Sæt en pris på varen");
                string setPrice = Console.ReadLine();

                double price;
                double.TryParse(setPrice, out price);

                WarehouseRepo n = new WarehouseRepo();
                n.SetNewProduct(productName, quantity, price);

                Console.WriteLine("-----------------------------");
            } while (true);         
        }
    }
}
