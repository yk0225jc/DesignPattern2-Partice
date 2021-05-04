using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class ConcreteShipUpdate : ShipUpdate
    {

        public void SystemUpdate(SpaceShipAssociate shipComponent, SpaceStationComponents stationcomponent)
        {
            double temHolder = shipComponent.powerRating;
            shipComponent.powerRating = stationcomponent.powerRating;
            Console.WriteLine("Component updated! Rating from " + temHolder + " to " + shipComponent.powerRating);
        }ddd



    }
}
