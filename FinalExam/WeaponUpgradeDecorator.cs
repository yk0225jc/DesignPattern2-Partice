using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class WeaponUpgradeDecorator : Decorator
    {
        public WeaponUpgradeDecorator(ShipUpdate aShipUpdate) : base(aShipUpdate)
        {

        }
        public override double SystemUpdate(SpaceShipAssociate shipComponent, SpaceStationComponents stationcomponent)
        {
            double temHolder = shipComponent.powerRating;
            shipComponent.powerRating = stationcomponent.powerRating;
            double shipNewWeaponRating = shipComponent.powerRating;
            Console.WriteLine("Weapon upgraded! Power Rating went from " + temHolder + " to " + shipComponent.powerRating);
            return shipComponent.powerRating;
        }
    }
}
