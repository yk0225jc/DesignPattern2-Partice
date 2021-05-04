//Written by Jiameng Zhou
// 05/02/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class SpaceShip :IObserver
    {
        public string shipName;
        public string shipLocation;
        public int shipCredits;
        public Item shipItemForSale;
        public Item shipItemWanted;

        public SpaceShipAssociate engine;
        public SpaceShipAssociate weapon;
        public SpaceShipAssociate shield;
        
        public SpaceShip(string aName, string aLocation, int aCredit, Item aItemForSale, Item aItemWanted, SpaceShipAssociate aEngine, SpaceShipAssociate aWeapon, SpaceShipAssociate aShield)
        {
            this.shipName = aName;
            this.shipLocation = aLocation;
            this.shipCredits = aCredit;
            this.shipItemForSale = aItemForSale;
            this.shipItemWanted = aItemWanted;
            this.engine = aEngine;
            this.weapon = aWeapon;
            this.shield = aShield;
        }

        public string ShipName
        {
            get { return this.shipName; }
            set { this.shipName = value ; }

        }
        public string ShipLocation
        {
            get { return this.shipLocation; }
            set { this.shipLocation = value; }
        }
        public int ShipCredits
        {
            get { return this.shipCredits; }
            set { this.shipCredits = value;  }
        }
        public Item ShipItemForSale
        {
            get { return this.shipItemForSale; }
            set { this.shipItemForSale = value;  }
        }
        public Item ShipItemWanted
        {
            get { return this.shipItemWanted; }
            set { this.shipItemWanted = value;  }
        }

        public SpaceShipAssociate Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }
        public SpaceShipAssociate Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }
        public SpaceShipAssociate Shield
        {
            get { return this.shield; }
            set { this.shield = value; }
        }





        public void SellItem(Item sellItem, int quantitySell)
        {
            if(quantitySell > shipItemForSale.quantity) // if you want to sell more than what you have in stock.
            {
                Console.WriteLine("Not enought in stock to Sell! only have  " + sellItem.quantity);
            }
            else
            {
                shipCredits += quantitySell * sellItem.unitPrice; // add apple sale credits to SpaceShip credits
                shipItemForSale.quantity -= quantitySell; // the SpaceShip apple quantity decrease;
                sellItem.quantity += quantitySell; // the space station apple quantity increase


            }
        }
        public void BuyItem(Item buyItem, int quantityBuy)
        {
            if (quantityBuy > buyItem.quantity)
            {
                Console.WriteLine("Not enought in stock!, only have " + buyItem.quantity);
            }
            else if (buyItem.unitPrice * quantityBuy > shipCredits)
            {
                Console.WriteLine("Not Enought credits to purchase, only have " + shipCredits);
            }
            else
            {
                shipCredits -= (buyItem.unitPrice * quantityBuy); //minus the SpaceShip credits due to buy new apples
                shipItemForSale.quantity += quantityBuy; // the SpaceShip apple quantity increase
                buyItem.quantity -= quantityBuy; // the space station apple quantity decrease
            }
        }

        public void FlyToSpaceStation(SpaceStation spaceStation)
        {
           // Console.WriteLine(spaceStation.itemForSale + "\n " + spaceStation.itemForSale.quantity + "\n" + (spaceStation.itemForSale.unitPrice * spaceStation.itemForSale.quantity));
            BuyItem(spaceStation.itemForSale, shipItemWanted.quantity); // auto buy what spaceship wants

        }

        public override string ToString()
        {
            return
                "Space Ship Name: " + shipName + "\n" +
                "Location: " + shipLocation + "\n" +
                "Credits: " + shipCredits + "\n" + "\n" +
                "Items for Sale: "
                + "\n" + shipItemForSale.ToString() +
                 "\n" + "\n" + "Items Wanted: " + "\n" + shipItemWanted.ToString();
        }

        public void React(Item aItemForSale, Item aItemWanted)
        {

            this.shipItemForSale = aItemForSale;
            this.shipItemWanted = aItemWanted;
        }
    }
}
