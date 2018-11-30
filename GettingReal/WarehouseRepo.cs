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

        //Visuel Studio viser en masse røde streger 
        //Vi skal implementere en ny type "Products", så vi kan oprette objekterne til typen
        private List<Products> productList = new List<Products>();

        public void TestItems()
        {
            //***Test Items***
            productList = new List<Products>
           {
               new Products("Hvid Maling"),
               new Products("Grå Maling"),
               new Products("Beige Maling"),
               new Products("Gul Maling"),
               new Products("Rød Maling")
           };
        }

        public void ProductList()
        {
            TestItems();
            //Implementer en måde at vise listen productList på
        }        
    }
}
