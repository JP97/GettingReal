using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Warehouse
    {
        public void ItemList()
        {
            List<string> myItems = new List<string>();
            myItems.Add("Hvid");
            myItems.Add("Grå");
            myItems.Add("Beige");
            myItems.Add("Rød");

            foreach (string obj in myItems)
            {
                Console.WriteLine(obj + " Maling");
            }
        }
    }
}
