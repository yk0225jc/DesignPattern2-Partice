//Written by Jiameng Zhou
// 5/3/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class SpaceShipAssociate
    {
        public double powerRating;

        public SpaceShipAssociate(double aPowerRating)
        {
            this.powerRating = aPowerRating;
        }

        public double PowerRating
        {
            get { return this.powerRating; }
            set { this.powerRating = value; }
        }

        public override string ToString()
        {
            return "Power Rating: " + powerRating;
        }
    }
}
