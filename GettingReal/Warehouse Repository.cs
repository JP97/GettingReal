using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Warehouse_Repository
    {
        public void ProductList()
        {
            List<string> MyProductList = new List<string>();
            {
                MyProductList.Add("Hvid maling");
                MyProductList.Add("Sort maling");
                MyProductList.Add("Brun maling");
                MyProductList.Add("Fyn Brun (altså Brån) maling");
            }
            foreach (var item in MyProductList)
            {

            Console.WriteLine(item);
            }
        }
    }
}
