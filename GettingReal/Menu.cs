using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Menu
    {
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
                        ShowStock();
                        break;
                    default:
                        Console.WriteLine("Prøv igen, dummy.");
                        Console.ReadLine();
                        break;
                }
            } while (running);
        }

        private void ShowMenu()
        {
            Console.WriteLine("Get Real~~~~~~");
            Console.WriteLine("");
            Console.WriteLine("1. Vis Varer");//Implementer Vis varer på lager? -Sådan at varer ikke på lager, skjules fra brugeren?
            Console.WriteLine("2. Opdater Varelager");
            Console.WriteLine("");
            Console.WriteLine("0. Ãfslut Konsol");
        }

        private string GetUserChoice()
        {
            Console.WriteLine();
            Console.Write("Hvad kunne du tænke dig at gøre?: ");
            return Console.ReadLine();
        }

        public void ShowStock()
        {
            Console.WriteLine("-----------------------------");
            Warehouse myStuff = new Warehouse();
            myStuff.ItemList();
            Console.WriteLine("-----------------------------");
        }
        public void UpdateStock()
        {
            Console.WriteLine("-----------------------------");
            //Vis Vareliste igen, med valgmulighed for at opdatere antal af enkelte items i listen? 
            Console.WriteLine("-----------------------------");
        }

    }
}
