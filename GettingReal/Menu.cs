using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("1.Show Product List");
                       
        }

        public void SwitchSystem()
        {
            ShowMenu();
            
            string Input = Console.ReadLine();
            switch (Input)
            {
                default:
                    Console.WriteLine("menu eksistere ikke");
                    Console.ReadLine();
                    break;
                case "1":
                    ShowProducts();
                    break;
                case "2":
                    Console.WriteLine("test 2");
                    break;
                case "3":
                    Console.WriteLine("test 3");
                    break;
            }
        }
        public void ShowProducts()
        {
            Warehouse_Repository w = new Warehouse_Repository();
            w.ProductList();
        }
            
    }
}
