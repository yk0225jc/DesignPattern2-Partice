using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class SpaceShip
    {
        public string name;
        public string location;
        public double credits;
        public Item itemForSale;
        public Item itemWanted;

        public SpaceShip(string aName, string aLocation, double aCredit, Item aItemForSale, Item aItemWanted)
        {
            this.name = aName;
            this.location = aLocation;
            this.credits = aCredit;
            this.itemForSale = aItemForSale;
            this.itemWanted = aItemWanted;
        }



        public void BuyItem(Item buyItem, int quantityBuy)
        {
            if (quantityBuy > buyItem.quantity)
            {
                Console.WriteLine("Not enought in stock!, only have " + buyItem.quantity);
            }
            else if (buyItem.unitPrice * quantityBuy > credits)
            {
                Console.WriteLine("Not Enought credits to purchase, only have " + credits);
            }
            else
            {
                credits -= (buyItem.unitPrice * quantityBuy); //minus the SpaceShip credits due to buy new apples
                itemForSale.quantity += quantityBuy; // the SpaceShip apple quantity increase
                buyItem.quantity -= quantityBuy; // the space station apple quantity decrease
            }
        }
        public void SellItem(Item sellItem, int quantitySell)
        {
            if(quantitySell > sellItem.quantity)
            {
                Console.WriteLine("Not enought in stock to Sell! only have  " + sellItem.quantity);
            }
            else
            {
                credits += quantitySell * sellItem.unitPrice; // add apple sale credits to SpaceShip credits
                itemForSale.quantity -= quantitySell; // the SpaceShip apple quantity decrease;
                sellItem.quantity += quantitySell; // the space station apple quantity increase


            }
        }

        public void FlyToSpaceStation(SpaceStation spaceStation, IObserver observer)
        {
            spaceStation.aListOfSpaceShips.Add(observer);
            observer.React(this.name, this.location, this.credits, this.itemForSale, this.itemWanted);
            BuyItem(spaceStation.itemForSale, spaceStation.itemForSale.quantity); // auto buy what spaceship wants

        }

        public override string ToString()
        {
            return
                "Space Ship Name: " + name + "\n" +
                "Location: " + location + "\n" +
                "Credits: " + credits + "\n" + "\n" +
                "Items for Sale: "
                + "\n" + itemForSale.ToString() +
                 "\n" + "\n" + "Items Wanted: " + "\n" + itemWanted.ToString();
        }


    }
}
