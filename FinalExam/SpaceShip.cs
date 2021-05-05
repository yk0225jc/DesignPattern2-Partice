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

        public List<Item> shipItemsForSale = new List<Item>();
        public List<Item> shipItemsWanted = new List<Item>();



        public SpaceShipAssociate engine;
        public SpaceShipAssociate weapon;
        public SpaceShipAssociate shield;
        
        public SpaceShip(string aName, string aLocation, int aCredit, SpaceShipAssociate aEngine, SpaceShipAssociate aWeapon, SpaceShipAssociate aShield)
        {
            this.shipName = aName;
            this.shipLocation = aLocation;
            this.shipCredits = aCredit;
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
        public List<Item> ShipItemsForSale
        {
            get { return this.shipItemsForSale; }
            set { this.shipItemsForSale = value;  }
        }
        public List<Item> ShipItemsWanted
        {
            get { return this.shipItemsWanted; }
            set { this.shipItemsWanted = value;  }
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
            if(quantitySell > sellItem.quantity) // if you want to sell more than what you have in stock.
            {
                Console.WriteLine("Not enought in stock to Sell! only have  " + sellItem.quantity);
            }
            else
            {
                shipCredits += quantitySell * sellItem.unitPrice; // add apple sale credits to SpaceShip credits
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
                buyItem.quantity -= quantityBuy; // the space station apple quantity decrease
            }
        }

        public void FlyToSpaceStation(SpaceStation spaceStation)
        {
            for(int i = 0; i < shipItemsWanted.Count; i++) 
            {
                for(int x = 0; x < spaceStation.itemsForSale.Count; x++)
                {
                    if (spaceStation.itemsForSale[x].name == shipItemsWanted[i].name) // spaceship and space station items name should be the same, to ensure the same item
                    {
                        if (spaceStation.itemsForSale[x].unitPrice > shipItemsWanted[i].unitPrice) // if space station item price is higher than what space ship expected, then don't buy
                        {
                            Console.WriteLine(spaceStation.itemsForSale[x].name + " cost more than the space ship expected price, therefore don't buy");

                        }
                        else
                        {
                            BuyItem(spaceStation.itemsForSale[x], shipItemsWanted[i].quantity); // auto buy what space ship wants from Space Station
                            Console.WriteLine("Purchased, " + spaceStation.itemsForSale[x].name + ", Total Price: "
                                + spaceStation.itemsForSale[x].unitPrice * shipItemsWanted[i].quantity + ", Quantity: " + shipItemsWanted[i].quantity
                                + ", Single unit price:" + spaceStation.itemsForSale[x].unitPrice);
                        }
                    }
                }


                
            }
            

        }

        public void BuyComponent(SpaceStationComponents aComponent)
        {
            shipCredits -= aComponent.unitPrice; // reduce the credit of the ship, for Components
        }

        public void ShowItems(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine((items[i].ToString()));
            }

        }



        public override string ToString()
        {
            
            return
                "Space Ship Name: " + shipName + "\n" +
                "Location: " + shipLocation + "\n" +
                "Credits: " + shipCredits + "\n" + "Engine "+engine + "\n"+
                "Weapon " + weapon + "\n"+ "Shield " + shield + "\n";

        }

        public void React(List<Item> ItemsForSale, List<Item> ItemsWanted)
        {

            this.shipItemsForSale = ItemsForSale;
            this.shipItemsWanted = ItemsWanted;
        }
    }
}
