//Written by Jiameng Zhou
// 05/02/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class SpaceStation :ISubject
    {
        public string name;
        public string location;
        public int credits;
        public List<Item> itemsForSale = new List<Item>();
        public List<Item> itemsWanted = new List<Item>();


        public List<SpaceStationComponents> engine = new List<SpaceStationComponents>();
        public List<SpaceStationComponents> weapon = new List<SpaceStationComponents>();
        public List<SpaceStationComponents> shield = new List<SpaceStationComponents>();

        public SpaceStation(string aName, string aLocation, int aCredits)
        {
            this.name = aName;
            this.location = aLocation;
            this.credits = aCredits;

        }

        public List<IObserver> aListOfSpaceShips = new List<IObserver>();



        public string Name
        {
            get { return this.name; }
            set { this.name = value; this.Notify(); }

        }
        public string Location
        {
            get { return this.location; }
            set { this.location = value; this.Notify();}
        }
        public int Credits
        {
            get { return this.credits; }
            set { this.credits=value; this.Notify();}
        }
        public List<Item> ItemForSale
        {
            get { return this.itemsForSale; }
            set { this.itemsForSale = value; this.Notify();}
        }
        public List<Item> ItemWanted
        {
            get { return this.itemsWanted; }
            set { this.itemsWanted = value;this.Notify();}
        }
        


        public void Attach(IObserver anObserver)
        {
            aListOfSpaceShips.Add(anObserver);
            //anObserver.React(this.itemForSale, this.itemWanted);
            Console.WriteLine("Welcome to " + name + " !!!");

        }

        public void Detach(IObserver anObserver)
        {
            aListOfSpaceShips.Remove(anObserver);
        }

        public void Notify()
        {
            foreach(var ship in aListOfSpaceShips)
            {
                ship.React(this.itemsForSale, this.itemsWanted);
            }
        }
        public void ShowItems(List<Item> items)
        {
            for(int i = 0; i < items.Count; i++)
            {
                Console.WriteLine ((items[i].ToString()));
            }
            
        }

        public override string ToString()
        {
            return
                "Space Station Name: " + name + "\n" +
                "Location: " + location + "\n" +
                "Credits: " + credits + "\n" + "\n" ;


        }

    }
}


