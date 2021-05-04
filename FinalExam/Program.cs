//Written by Jiameng Zhou
// 05/02/2021
using System;

namespace FinalExam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------Status before ship get there-----------------------------------------------------------");
            //1st Space Station
            Console.WriteLine("\n");
            Item appleSaleST1 = new Item("Apple", "Fruit", "AP1", 3, 10000);
            Item appleWantedST1 = new Item("Apple", "Fruit", "AP1", 3, 3000);
            SpaceStation SpaceStation1 = new SpaceStation("Death Star Version 1.0", "N12S23", 10000, appleSaleST1, appleWantedST1);
            Console.WriteLine(SpaceStation1.ToString());
            Console.WriteLine("\n" + "\n");

            //2nd Space Station
            Item appleSaleST2 = new Item("Apple", "Fruit", "AP1", 3, 5000);
            Item appleWantedST2 = new Item("Apple", "Fruit", "AP1", 3, 1000);
            SpaceStation SpaceStation2 = new SpaceStation("Death Start Version 2.0", "N55S78", 10000, appleSaleST2, appleWantedST2);
            Console.WriteLine(SpaceStation2.ToString());
            Console.WriteLine("\n" + "\n");

            // SpaceShip
            Item appleSaleSS1 = new Item("Apple", "Fruit", "AP1", 3, 200);
            Item appleWantedSS1 = new Item("Apple", "Fruit", "AP1", 3, 50);
            SpaceShip SpaceShip1 = new SpaceShip("SpaceShip1", "N92S23", 300000, appleSaleSS1, appleWantedSS1);
            Console.WriteLine(SpaceShip1.ToString());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("\n" + "\n");


            Console.WriteLine("---------------------------------Status when ship arrive to Death Star Verison 1.0--------------------------------------");
            Console.WriteLine("\n");
            SpaceStation1.Attach(SpaceShip1); // SpaceShip arrive to SpaceStation1
            SpaceShip1.FlyToSpaceStation(SpaceStation1); // Auto buy
            SpaceStation1.Detach(SpaceShip1); // eject the the SpaceShip
            Console.WriteLine("\n");
            Console.WriteLine("Status after arrive to Death Start Version 1.0: ");
            Console.WriteLine("\n");
            Console.WriteLine(SpaceShip1.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(SpaceStation1.ToString());
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n" + "\n");

            Console.WriteLine("---------------------------------Status when ship arrive to Death Star Verison 2.0--------------------------------------");
            Console.WriteLine("\n");
            SpaceStation2.Attach(SpaceShip1); // SpaceShip arrive to SpaceStation2
            SpaceShip1.FlyToSpaceStation(SpaceStation2); // Auto buy
            SpaceStation2.Detach(SpaceShip1); // eject the the SpaceShip
            Console.WriteLine("\n");
            Console.WriteLine("Status after arrive to Death Start Version 1.0: ");
            Console.WriteLine("\n");
            Console.WriteLine(SpaceShip1.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(SpaceStation2.ToString());
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

            //Decorator pattern example.
/*            //Create EcomomyCar instance.   
            ICar objCar = new EconomyCar();

            //Wrp EconomyCar instancw with BasicAccessories.   
            CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);

            //Wrap EconomyCar instance with AdvancedAccessories instance.   
            objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);

            Console.Write("Car Detials: " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine("\n\n");
            Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());

            Console.Read();*/


            Console.Read();
        }
    }
}
