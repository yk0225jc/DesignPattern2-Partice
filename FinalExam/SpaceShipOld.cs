//Writen by Jiameng Zhou
// 05/06/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class SpaceShipOld : IObserver
    {
        public string shipName;
        public string shipLocation;
        public int shipCredits;

        public List<Item> shipItemsForSale = new List<Item>();
        public List<Item> shipItemsWanted = new List<Item>();



        public SpaceShipAssociate engine;
        public SpaceShipAssociate weapon;
        public SpaceShipAssociate shield;

        public SpaceShipOld(string aName, string aLocation, int aCredit, SpaceShipAssociate aEngine, SpaceShipAssociate aWeapon, SpaceShipAssociate aShield)
        {
            this.shipName = aName;
            this.shipLocation = aLocation;
            this.shipCredits = aCredit;
            this.engine = aEngine;
            this.weapon = aWeapon;
            this.shield = aShield;
        }
        //Sell and buy an item one at a time
        public void SellItem(Item sellItem, int quantityBuy) 
        {
                shipCredits += 1 * sellItem.unitPrice; // add apple sale credits to SpaceShip credits
                sellItem.quantity += 1; // the space station apple quantity increase
            
        }
        public void BuyItem(Item buyItem, int quantityBuy)
        {
            shipCredits -= (buyItem.unitPrice * 1); //minus the SpaceShip credits due to buy new apples
            buyItem.quantity -= 1; // the space station apple quantity decrease
        }

        public void React(List<Item> aItemForSale, List<Item> aItemWanted)
        {
            this.shipItemsForSale = aItemForSale;
            this.shipItemsWanted = aItemWanted;
        }

        public override string ToString()
        {

            return
                "Space Ship Name: " + shipName + "\n" +
                "Location: " + shipLocation + "\n" +
                "Credits: " + shipCredits + "\n" + "Engine " + engine + "\n" +
                "Weapon " + weapon + "\n" + "Shield " + shield + "\n";

        }


    }

   }

