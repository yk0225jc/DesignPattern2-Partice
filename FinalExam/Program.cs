using System;

namespace FinalExam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1st Space Station
            Item appleSaleST1 = new Item("Apple", "Fruit", "AP1", 3.00, 10000);
            Item appleWantedST1 = new Item("Apple", "Fruit", "AP1", 3.00, 3000);
            SpaceStation SpaceStation1 = new SpaceStation("SpaceStation1", "N12S23", 10000, appleSaleST1, appleWantedST1);
            Console.WriteLine(SpaceStation1.ToString());
            Console.WriteLine("\n" + "\n");

            //2nd Space Station
            Item appleSaleST2 = new Item("Apple", "Fruit", "AP1", 3.00, 5000);
            Item appleWantedST2 = new Item("Apple", "Fruit", "AP1", 3.00, 1000);
            SpaceStation SpaceStation2 = new SpaceStation("SpaceStation2", "N55S78", 10000, appleSaleST2, appleWantedST2);
            Console.WriteLine(SpaceStation2.ToString());

            Console.WriteLine("\n"+ "\n");
            // SpaceShip
            Item appleSaleSS1 = new Item("Apple", "Fruit", "AP1", 3.00, 200);
            Item appleWantedSS1 = new Item("Apple", "Fruit", "AP1", 3.00, 100);
            SpaceShip SS1 = new SpaceShip("SpaceShip1", "N92S23", 3000, appleSaleSS1, appleWantedSS1);
            Console.WriteLine(SS1.ToString());

            SpaceStation1.Attach(SS1);

            Console.Read();
        }
    }
}
