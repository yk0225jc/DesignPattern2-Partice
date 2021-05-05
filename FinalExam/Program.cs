//Written by Jiameng Zhou
// 05/02/2021
using System;

namespace FinalExam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------Status BEFORE ship get there-----------------------------------------------------------");
            //1st Space Station
            Console.WriteLine("\n");
            //Create 1st Space Station
            SpaceStation SpaceStation1 = new SpaceStation("Death Star Version 1.0", "N12S23", 10000);
            //Item for sale
            Item goldsSale = new Item("Gold", "Metal", "SS1", 70, 200);
            Item diamondsSale = new Item("Diamond", "Metal", "SS1", 30, 200);
            //Item Wanted
            Item goldsWanted = new Item("Gold", "Metal", "SS1", 10, 200);
            Item platinumsWanted = new Item("Platinum", "Metal", "SS1", 20, 200);
            Item diamondsWanted = new Item("Diamond", "Metal", "SS1", 30, 200);
            //Add the Item for Sale List
            SpaceStation1.itemsForSale.Add(goldsSale);
            SpaceStation1.itemsForSale.Add(diamondsSale);
            //Add the item for Wanted List
            SpaceStation1.itemsWanted.Add(goldsWanted);
            SpaceStation1.itemsWanted.Add(platinumsWanted);
            SpaceStation1.itemsWanted.Add(diamondsWanted);

            //Weapons
            SpaceStationComponents basicWeapon = new SpaceStationComponents("Basic Weapon", 500, 5000);
            SpaceStationComponents eliteWeapon = new SpaceStationComponents("Elite Weapon", 1000, 7000);
            SpaceStationComponents supremeWeapon = new SpaceStationComponents("Supreme Weapon", 2000, 9000);
            //Engines
            SpaceStationComponents basicEngine = new SpaceStationComponents("Basic Engine", 500, 5000);
            SpaceStationComponents eliteEngine = new SpaceStationComponents("Elite Engine", 1000, 7000);
            SpaceStationComponents supremeEngine = new SpaceStationComponents("Supreme Engine", 2000, 9000);
            //Shields
            SpaceStationComponents basicShield = new SpaceStationComponents("Basic Shield", 500, 5000);
            SpaceStationComponents eliteShield = new SpaceStationComponents("Elite Shield", 1000, 7000);
            SpaceStationComponents supremeShield = new SpaceStationComponents("Supreme Shield", 2000, 9000);
            
            //Add weapons to the list
            SpaceStation1.weapon.Add(basicWeapon);
            SpaceStation1.weapon.Add(eliteWeapon);
            SpaceStation1.weapon.Add(supremeWeapon);
            //Add Engines to the list
            SpaceStation1.engine.Add(basicEngine);
            SpaceStation1.engine.Add(eliteEngine);
            SpaceStation1.engine.Add(supremeEngine);
            //Add Shields to the list
            SpaceStation1.shield.Add(basicShield);
            SpaceStation1.shield.Add(eliteShield);
            SpaceStation1.shield.Add(supremeShield);

            Console.WriteLine( SpaceStation1.ToString());
            Console.WriteLine("Items for Sale: ");
            SpaceStation1.ShowItems(SpaceStation1.itemsForSale);
            Console.WriteLine("\n"+"Items Wanted: ");
            SpaceStation1.ShowItems(SpaceStation1.itemsWanted);
            Console.WriteLine("\n" + "\n");

            //2nd Space Station
            Console.WriteLine("\n");
            SpaceStation SpaceStation2 = new SpaceStation("Death Star Version 2.0", "N22S89", 10000);
            //Item for sale
            Item goldsSale2 = new Item("Gold", "Metal", "SS1", 10, 200);
            Item platinumsSale2 = new Item("Platinum", "Metal", "SS1", 20, 200);
            Item diamondsSale2 = new Item("Diamond", "Metal", "SS1", 30, 200);
            //Item Wanted
            Item goldsWanted2 = new Item("Gold", "Metal", "SS1", 10, 200);
            Item platinumsWanted2 = new Item("Platinum", "Metal", "SS1", 10, 200);
            Item diamondsWanted2 = new Item("Diamond", "Metal", "SS1", 10, 200);
            //Add the Item for Sale List
            SpaceStation2.itemsForSale.Add(goldsSale2);
            SpaceStation2.itemsForSale.Add(platinumsSale2);
            SpaceStation2.itemsForSale.Add(diamondsSale2);
            //Add the item for Wanted List
            SpaceStation2.itemsWanted.Add(goldsWanted2);
            SpaceStation2.itemsWanted.Add(platinumsWanted2);
            SpaceStation2.itemsWanted.Add(diamondsWanted2);

            //Weapons
            SpaceStationComponents basicWeapon2 = new SpaceStationComponents("Basic Weapon", 500, 5500);
            SpaceStationComponents eliteWeapon2 = new SpaceStationComponents("Elite Weapon", 1000, 7700);
            SpaceStationComponents supremeWeapon2 = new SpaceStationComponents("Supreme Weapon", 2000, 9500);
            //Engines
            SpaceStationComponents basicEngine2 = new SpaceStationComponents("Basic Engine", 500, 5500);
            SpaceStationComponents eliteEngine2 = new SpaceStationComponents("Elite Engine", 1000, 7700);
            SpaceStationComponents supremeEngine2 = new SpaceStationComponents("Supreme Engine", 2000, 9500);
            //Shields
            SpaceStationComponents basicShield2 = new SpaceStationComponents("Basic Shield", 500, 5500);
            SpaceStationComponents eliteShield2 = new SpaceStationComponents("Elite Shield", 1000, 7700);
            SpaceStationComponents supremeShield2 = new SpaceStationComponents("Supreme Shield", 2000, 9500);

            //Add weapons to the list
            SpaceStation2.weapon.Add(basicWeapon2);
            SpaceStation2.weapon.Add(eliteWeapon2);
            SpaceStation2.weapon.Add(supremeWeapon2);
            //Add Engines to the list
            SpaceStation2.engine.Add(basicEngine2);
            SpaceStation2.engine.Add(eliteEngine2);
            SpaceStation2.engine.Add(supremeEngine2);
            //Add Shields to the list
            SpaceStation2.shield.Add(basicShield2);
            SpaceStation2.shield.Add(eliteShield2);
            SpaceStation2.shield.Add(supremeShield2);

            Console.WriteLine(SpaceStation2.ToString());
            Console.WriteLine("Items for Sale: ");
            SpaceStation2.ShowItems(SpaceStation2.itemsForSale);
            Console.WriteLine("\n" + "Items Wanted: ");
            SpaceStation2.ShowItems(SpaceStation2.itemsWanted);
            Console.WriteLine("\n" + "\n");



            // SpaceShip
            //weapon
            SpaceShipAssociate weapon = new SpaceShipAssociate(2000);
            SpaceShipAssociate engine = new SpaceShipAssociate(2000);
            SpaceShipAssociate shield = new SpaceShipAssociate(2000);
            //Create SpaceShip
            SpaceShip SpaceShip1 = new SpaceShip("SpaceShip1", "N92S23", 5000, engine, weapon, shield);
            //Item for sale
            Item goldsSale3 = new Item("Gold", "Metal", "SS1", 10, 200);
            Item platinumsSale3 = new Item("Platinum", "Metal", "SS1", 20, 200);
            Item diamondsSale3 = new Item("Diamond", "Metal", "SS1", 30, 200);
            //Item Wanted
            Item goldsWanted3 = new Item("Gold", "Metal", "SS1", 10, 10);
            Item platinumsWanted3 = new Item("Platinum", "Metal", "SS1", 20, 10);
            Item diamondsWanted3 = new Item("Diamond", "Metal", "SS1", 30, 10);
            //Add the Item for Sale List
            SpaceShip1.shipItemsForSale.Add(goldsSale3);
            SpaceShip1.shipItemsForSale.Add(platinumsSale3);
            SpaceShip1.shipItemsForSale.Add(diamondsSale3);
            //Add the item for Wanted List
            SpaceShip1.shipItemsWanted.Add(goldsWanted3);
            SpaceShip1.shipItemsWanted.Add(platinumsWanted3);
            SpaceShip1.shipItemsWanted.Add(diamondsWanted3);

            Console.WriteLine(SpaceShip1.ToString());
            Console.WriteLine("Items for Sale: ");
            SpaceShip1.ShowItems(SpaceShip1.shipItemsForSale);
            Console.WriteLine("\n" + "Items Wanted: ");
            SpaceShip1.ShowItems(SpaceShip1.ShipItemsWanted);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("\n" + "\n");


           Console.WriteLine("---------------------------------Status when ship arrive to Death Star Verison 1.0--------------------------------------");
            Console.WriteLine("\n");
            SpaceStation1.Attach(SpaceShip1); // SpaceShip arrive to SpaceStation1
            SpaceShip1.FlyToSpaceStation(SpaceStation1); // Auto buy
            SpaceStation1.Detach(SpaceShip1); // eject the the SpaceShip
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            //Space Ship 1 Status
            Console.WriteLine(SpaceShip1.ToString());
            Console.WriteLine("Items for Sale: ");
            SpaceShip1.ShowItems(SpaceShip1.shipItemsForSale);
            Console.WriteLine("\n" + "Items Wanted: ");
            SpaceShip1.ShowItems(SpaceShip1.ShipItemsWanted);
            Console.WriteLine("\n");
            //Space Station 1 Status
            Console.WriteLine(SpaceStation1.ToString());
            Console.WriteLine("Items for Sale: ");
            SpaceStation1.ShowItems(SpaceStation1.itemsForSale);
            Console.WriteLine("\n" + "Items Wanted: ");
            SpaceStation1.ShowItems(SpaceStation1.itemsWanted);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n" + "\n");
             
            Console.WriteLine("---------------------------------Status when ship arrive to Death Star Verison 2.0--------------------------------------");
            Console.WriteLine("\n");
            SpaceStation2.Attach(SpaceShip1); // SpaceShip arrive to SpaceStation2
            SpaceShip1.FlyToSpaceStation(SpaceStation2); // Auto buy
            SpaceStation2.Detach(SpaceShip1); // eject the the SpaceShip
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            //Space Ship 1 Status
            Console.WriteLine(SpaceShip1.ToString());
            Console.WriteLine("Items for Sale: ");
            SpaceShip1.ShowItems(SpaceShip1.shipItemsForSale);
            Console.WriteLine("\n" + "Items Wanted: ");
            SpaceShip1.ShowItems(SpaceShip1.ShipItemsWanted);
            Console.WriteLine("\n");
            //Space Station 2 Status
            Console.WriteLine(SpaceStation2.ToString());
            Console.WriteLine("Items for Sale: ");
            SpaceStation2.ShowItems(SpaceStation2.itemsForSale);
            Console.WriteLine("\n" + "Items Wanted: ");
            SpaceStation2.ShowItems(SpaceStation2.itemsWanted);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

            
            Console.WriteLine("---------------------------------Status BEFORE upgrade any ship components-----------------------------------------------");
            Console.WriteLine(SpaceShip1.ToString());

            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("---------------------------------Components upgrading-----------------------------------------------------------------------");
            //Create aShipUpdate instance.   
            ShipUpdate aShipUpdate = new ConcreteShipUpdate();
            Decorator weaponUpgrade = new WeaponUpgradeDecorator(aShipUpdate);

            //Ask what weapon user want to upgrade to
            Console.WriteLine("Please select a weapon that you want upgrade to: " + "\n" +
                "Press 1,2,or 3" + "\n" + " [1] Basic verison: Power Rating-" + SpaceStation1.weapon[0].powerRating + "  Cost: " + SpaceStation1.weapon[0].unitPrice + "\n" +
                " [2] Elite verison: Power Rating-" + +SpaceStation1.weapon[1].powerRating + "  Cost: " + SpaceStation1.weapon[1].unitPrice + "\n" +
                " [3] Supreme verison: Power Rating-" + +SpaceStation1.weapon[2].powerRating + "  Cost: " + SpaceStation1.weapon[2].unitPrice + "\n" +
                "Your current Credits: " + SpaceShip1.shipCredits);
            var userInputWeapon = Console.ReadLine();
            var UIW = Convert.ToInt32(userInputWeapon);//convert user input to a int type
            weaponUpgrade.SystemUpdate(SpaceShip1.weapon, SpaceStation1.weapon[UIW - 1]);
            SpaceShip1.BuyComponent(SpaceStation1.weapon[UIW - 1]);//reduce the ship credit
            Console.WriteLine("\n" + "\n");

            //Ask what Engine user want to upgrade to 
            Console.WriteLine("Please select a engine that you want upgrade to: " + "\n" +
                "Press 1,2,or 3" + "\n" + " [1] Basic verison: Power Rating-" + SpaceStation1.engine[0].powerRating + "  Cost: " + SpaceStation1.engine[0].unitPrice + "\n" +
                " [2] Elite verison: Power Rating-" + +SpaceStation1.engine[1].powerRating + "  Cost: " + SpaceStation1.engine[1].unitPrice + "\n" +
                " [3] Supreme verison: Power Rating-" + +SpaceStation1.engine[2].powerRating + "  Cost: " + SpaceStation1.engine[2].unitPrice + "\n" +
                "Your current Credits: " + SpaceShip1.shipCredits);
            var userInputEngine = Console.ReadLine();
            var UIE = Convert.ToInt32(userInputEngine);//convert user input to a int type
            weaponUpgrade.SystemUpdate(SpaceShip1.engine, SpaceStation1.engine[UIE - 1]);
            SpaceShip1.BuyComponent(SpaceStation1.engine[UIW - 1]);//reduce the ship credit
            Console.WriteLine("\n" + "\n");

            //Ask what Shields that user want to upgrade to 
            Console.WriteLine("Please select a engine that you want upgrade to: " + "\n" +
                "Press 1,2,or 3" + "\n" + " [1] Basic verison: Power Rating-" + SpaceStation1.shield[0].powerRating + "  Cost: " + SpaceStation1.shield[0].unitPrice + "\n" +
                " [2] Elite verison: Power Rating-" + +SpaceStation1.shield[1].powerRating + "  Cost: " + SpaceStation1.shield[1].unitPrice + "\n" +
                " [3] Supreme verison: Power Rating-" + +SpaceStation1.shield[2].powerRating + "  Cost: " + SpaceStation1.shield[2].unitPrice + "\n" +
                "Your current Credits: " + SpaceShip1.shipCredits);
            var userInputShields = Console.ReadLine();
            var UIS = Convert.ToInt32(userInputShields);//convert user input to a int type
            weaponUpgrade.SystemUpdate(SpaceShip1.shield, SpaceStation1.shield[UIS - 1]);
            SpaceShip1.BuyComponent(SpaceStation1.shield[UIS - 1]);//reduce the ship credit
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");



            Console.WriteLine("---------------------------------Status AFTER upgrade any ship components-----------------------------------------------");
            Console.WriteLine("\n" + "\n");
            Console.WriteLine(SpaceShip1.ToString());//status after the upgrade
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine("---------------------------------Status for Space Ship old, BEFORE docking-----------------------------------------------");
            Console.WriteLine("\n");
            SpaceShipAssociate weapon2 = new SpaceShipAssociate(2000);
            SpaceShipAssociate engine2 = new SpaceShipAssociate(2000);
            SpaceShipAssociate shield2 = new SpaceShipAssociate(2000);
            SpaceShipOld spaceShip3 = new SpaceShipOld("SpaceShipOld", "N00S00", 5000, engine2, weapon2, shield2);
            //Item for sale
            Item goldsSale4 = new Item("Gold", "Metal", "SS1", 10, 200);
            Item platinumsSale4 = new Item("Platinum", "Metal", "SS1", 20, 200);
            Item diamondsSale4 = new Item("Diamond", "Metal", "SS1", 30, 200);
            //Item Wanted
            Item goldsWanted4 = new Item("Gold", "Metal", "SS1", 10, 10);
            Item platinumsWanted4 = new Item("Platinum", "Metal", "SS1", 20, 10);
            Item diamondsWanted4 = new Item("Diamond", "Metal", "SS1", 30, 10);
            //Add the Item for Sale List
            spaceShip3.shipItemsForSale.Add(goldsSale4);
            spaceShip3.shipItemsForSale.Add(platinumsSale4);
            spaceShip3.shipItemsForSale.Add(diamondsSale4);
            //Add the item for Wanted List
            spaceShip3.shipItemsWanted.Add(goldsWanted4);
            spaceShip3.shipItemsWanted.Add(platinumsWanted4);
            spaceShip3.shipItemsWanted.Add(diamondsWanted4);
            //Space Station 1 Status
            
            


            Console.WriteLine(spaceShip3.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(SpaceStation1.ToString());
            Console.WriteLine("Items for Sale: ");
            SpaceStation1.ShowItems(SpaceStation1.itemsForSale);
            Console.WriteLine("\n" + "Items Wanted: ");
            SpaceStation1.ShowItems(SpaceStation1.itemsWanted);

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            
            
            Console.WriteLine("---------------------------------Status for Space Ship old, AFTER docking-----------------------------------------------");

            Adapter newAdapter = new Adapter(spaceShip3);
            SpaceStation1.Attach(newAdapter); // SpaceShip arrive to SpaceStation2
            newAdapter.FlyToSpaceStation(SpaceStation1);
            Console.WriteLine(newAdapter.ToString());

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");






            


            Console.Read();
        }
    }
}







