//Writen by Jiameng Zhou
// 05/06/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class ShieldUpgradeDecorator : Decorator
    {
        public ShieldUpgradeDecorator(ShipUpdate aShipUpdate) : base(aShipUpdate)
        {

        }
        public override double SystemUpdate(SpaceShipAssociate shipComponent, SpaceStationComponents stationcomponent)
        {
            double temHolder = shipComponent.powerRating;
            shipComponent.powerRating = stationcomponent.powerRating;
            Console.WriteLine("Shield upgraded! Power Rating went from " + temHolder + " to " + shipComponent.powerRating);
            return shipComponent.powerRating;
        }
    }
}
