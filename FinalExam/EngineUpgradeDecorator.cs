using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class EngineUpgradeDecorator : Decorator
    {
        public EngineUpgradeDecorator(ShipUpdate aShipUpdate) : base(aShipUpdate)
        {

        }
        public override double SystemUpdate(SpaceShipAssociate shipComponent, SpaceStationComponents stationcomponent)
        {
            double temHolder = shipComponent.powerRating;
            shipComponent.powerRating = stationcomponent.powerRating;
            Console.WriteLine("Engine upgraded! Power Rating went from " + temHolder + " to " + shipComponent.powerRating);
            return shipComponent.powerRating;
        }
    }
}
