using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public interface IObserver
    {
        void React(string aName, string aLocation, double aCredit, Item aItemForSale, Item aItemWanted);
    }
}
