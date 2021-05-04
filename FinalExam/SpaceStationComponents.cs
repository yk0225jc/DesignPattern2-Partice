//Written by Jiameng Zhou
// 5/3/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class SpaceStationComponents
    {
        public string name;
        public int unitPrice;
        public double powerRating;

        public SpaceStationComponents(string aName, int aUnitPrice, double aPowerRating)
        {
            this.name = aName;
            this.unitPrice = aUnitPrice;
            this.powerRating = aPowerRating;

        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }
        public double PowerRating
        {
            get { return this.powerRating; }
            set { this.powerRating = value; }
        }
    }
}
