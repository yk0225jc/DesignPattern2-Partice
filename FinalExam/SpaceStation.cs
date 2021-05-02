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
        public double credits;
        public Item itemForSale;
        public Item itemWanted;

        public SpaceStation(string aName, string aLocation, double aCredits, Item itemForSale, Item itemWanted)
        {
            this.name = aName;
            this.location = aLocation;
            this.credits = aCredits;
            this.itemForSale = itemForSale;
            this.itemWanted = itemWanted;
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
            set { this.location = value; this.Notify(); }
        }
        public double Credits
        {
            get { return this.credits; }
            set { this.credits=value; this.Notify(); }
        }
        public Item ItemForSale
        {
            get { return this.itemForSale; }
            set { this.itemForSale = value; this.Notify(); }
        }
        public Item ItemWanted
        {
            get { return this.itemWanted; }
            set { this.itemWanted = value; this.Notify(); }
        }
        


        public void Attach(IObserver anObserver)
        {
            aListOfSpaceShips.Add(anObserver);
            anObserver.React(this.name, this.location, this.credits, this.itemForSale, this.itemWanted);
        }

        public void Detach(IObserver anObserver)
        {
            aListOfSpaceShips.Remove(anObserver);
        }

        public void Notify()
        {
            foreach(var ship in aListOfSpaceShips)
            {
                ship.React(this.name, this.location, this.credits, this.itemForSale, this.itemWanted);
            }
        }


        public override string ToString()
        {
            return 
                "Space Station Name: "+ name + "\n"+ 
                "Location: " + location+ "\n"+ 
                "Credits: " + credits+ "\n"+ "\n"+
                "Items for Sale: "
                + "\n" + ItemForSale.ToString() +
                 "\n" + "\n" + "Items Wanted: " + "\n" + ItemWanted.ToString();

        }

    }
}
