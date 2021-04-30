using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class SpaceShip
    {
        public string name = "SS1";
        public string location = "S22N123";
        public double credits = 200.00;

        Item appleForSale = new Item("Apple", "fruit", "SP1", 5, 70);
        Item bananaForSale = new Item("Banana", "fruit", "SP1", 2, 100);


        Item appleWanted = new Item("Apple", "fruit", "SP1", 5, 300);
        Item bananaWanted = new Item("Banana", "fruit", "SP1", 2, 250);

        public Item BuyItem(Item buyItem, int quantityBuy)
        {


        }

    }
}
