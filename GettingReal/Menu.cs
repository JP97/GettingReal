

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Menu
    {
        private Controller bridge = new Controller();

        public void Show()
        {
            bool running = true; //Registrere om programmet skal lukkes hvis switchCasen får inputtet "0" sættes denne til false

            do //Holder menuen åben så længe bool er true
            {
                ShowMenu(); //Instance af ShowMenu metode
                string choice = GetUserChoice(); //Instance af GetUserChoice metode
                switch (choice) //bruger string som henter GetUserChoice Metoden
                {
                    case "0":
                        running = false; //Sætter bool til false og lukker programmet
                        break;
                    case "1":
                        ShowProducts(); //Instance af metode 
                        break;
                    case "2":
                        RegisterNewProduct();//Instance af metode 
                        break;
                    default://Kører hvis userchoice ikke stemmer overens med nogen switch case
                        Console.WriteLine("Der er intet menupunkt for dit valg");
                        Console.WriteLine("prøv igen...");
                        Console.ReadLine();
                        break;
                }
            } while (running); //Do While loop slutter her
        }

        private void ShowMenu() //Menu udskrift
        {
            Console.WriteLine("Svanninge Malerforretning: Lagersystem");
            Console.WriteLine("");
            Console.WriteLine("1. Vis Varer");
            Console.WriteLine("2. Opret ny vare i systemet");
            Console.WriteLine("");
            Console.WriteLine("0. Afslut Systemet");
        }

        private string GetUserChoice() //Input metode
        {
            Console.WriteLine();
            Console.Write("Hvad kunne du tænke dig at gøre?: ");
            return Console.ReadLine();
        }

        public void ShowProducts() //Produkt Oversigt
        {
            Console.Clear();
            bridge.ShowProductList();
        }

        public void UpdateQuantity() //Opdater antal 
        {
            Console.Clear();
            bridge.UpdateQuantity();
        }
        public void RegisterNewProduct() //Opret nyt produkt
        {
            bridge.RegisterNewProduct();
        }
    }
}
