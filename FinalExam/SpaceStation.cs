using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class SpaceStation
    {
        public string Name = "SP1";
        public string location = "N12S99";
        public double credits = 1000;


        //Item for sale
        Item appleForSale = new Item("Apple", "fruit", "SP1", 5, 1000);
        Item bananaForSale = new Item("Banana", "fruit", "SP1", 2, 1000);



        //Item wanted
        Item appleWanted = new Item("Apple", "fruit", "SP1", 5, 300);
        Item bananaWanted = new Item("Banana", "fruit", "SP1", 2, 250);



        public override string ToString()
        {
            return "Items for Sale: "
                + "\n" + appleForSale.ToString() +
                "\n" + "\n" + bananaForSale.ToString()
                + "\n" + "\n" + "Items Wanted: "+ "\n"+ appleWanted.ToString()
                + "\n" + "\n" + bananaWanted.ToString();
        }



    }
}
