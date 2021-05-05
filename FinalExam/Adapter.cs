using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class Adapter :IObserver
    {
        private SpaceShipOld aSpaceShip;

        public Adapter(SpaceShipOld aSpaceship)
        {
            aSpaceShip = aSpaceship;
        }

        public void BuyItem(Item buyItem, int quantityBuy)
        {
            if (quantityBuy > buyItem.quantity)
            {
                Console.WriteLine("Not enought in stock!, only have " + buyItem.quantity);
            }
            else if (buyItem.unitPrice * quantityBuy > aSpaceShip.shipCredits)
            {
                Console.WriteLine("Not Enought credits to purchase, only have " + aSpaceShip.shipCredits);
            }
            else
            {

                aSpaceShip.shipCredits -= (buyItem.unitPrice * quantityBuy); //minus the SpaceShip credits due to buy new apples
                buyItem.quantity -= quantityBuy; // the space station apple quantity decrease
            }
        }
        public void FlyToSpaceStation(SpaceStation spaceStation)
        {
            for (int i = 0; i < aSpaceShip.shipItemsWanted.Count; i++)
            {
                for (int x = 0; x < spaceStation.itemsForSale.Count; x++)
                {
                    if (spaceStation.itemsForSale[x].name == aSpaceShip.shipItemsWanted[i].name) // spaceship and space station items name should be the same, to ensure the same item
                    {
                        if (spaceStation.itemsForSale[x].unitPrice > aSpaceShip.shipItemsWanted[i].unitPrice) // if space station item price is higher than what space ship expected, then don't buy
                        {
                            Console.WriteLine(spaceStation.itemsForSale[x].name + " cost more than the space ship expected price, therefore don't buy");

                        }
                        else
                        {
                            BuyItem(spaceStation.itemsForSale[x], aSpaceShip.shipItemsWanted[i].quantity); // auto buy what space ship wants from Space Station
                            Console.WriteLine("Purchased, " + spaceStation.itemsForSale[x].name + ", Total Price: "
                                + spaceStation.itemsForSale[x].unitPrice * aSpaceShip.shipItemsWanted[i].quantity + ", Quantity: " + aSpaceShip.shipItemsWanted[i].quantity
                                + ", Single unit price:" + spaceStation.itemsForSale[x].unitPrice);
                        }
                    }
                }



            }


        }

        public void React(List<Item> aItemForSale, List<Item> aItemWanted)
        {
            throw new NotImplementedException();
        }
    }
}
