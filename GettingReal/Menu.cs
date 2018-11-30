

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Menu
    {
        private Controller binding = new Controller();

        public void Show()
        {
            bool running = true;
            do
            {
                ShowMenu();
                string choice = GetUserChoice();
                switch (choice)
                {
                    case "0":
                        running = false;
                        break;
                    case "1":
                        ShowProducts();
                        break;
                    case "2":
                        RegisterNewProduct();
                        break;
                    default:
                        Console.WriteLine("Der er intet menupunkt for dit valg");
                        Console.WriteLine("prøv igen...");
                        Console.ReadLine();
                        break;
                }
            } while (running);
        }

        private void ShowMenu()
        {
            Console.WriteLine("Svanninge Malerforretning: Lagersystem");
            Console.WriteLine("");
            Console.WriteLine("1. Vis Varer");//Implementer Vis varer på lager? -Sådan at varer ikke på lager, skjules fra brugeren?
            Console.WriteLine("2. Opret ny vare i systemet");
            Console.WriteLine("");
            Console.WriteLine("0. Afslut Systemet");
        }

        private string GetUserChoice()
        {
            Console.WriteLine();
            Console.Write("Hvad kunne du tænke dig at gøre?: ");
            return Console.ReadLine();
        }

        public void ShowProducts()
        {
            Console.Clear();
            binding.ShowProductList();
        }
        public void RegisterNewProduct()
        {
            binding.RegisterNewProduct();
        }
    }
}
