//Writen by Jiameng Zhou
// 05/06/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public abstract class Decorator : ShipUpdate
    {
        ShipUpdate shipUpdate;

        public Decorator(ShipUpdate shipUpdate)
        {
            this.shipUpdate = shipUpdate;
        }

        public virtual double SystemUpdate(SpaceShipAssociate shipComponent, SpaceStationComponents stationcomponent)
        {
            return this.shipUpdate.SystemUpdate(shipComponent, stationcomponent);
        }


    }
}
