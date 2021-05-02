using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public interface ISubject
    {
        void Attach(IObserver anObserver);
        void Detach(IObserver anObserver);
        void Notify();
    }
}
