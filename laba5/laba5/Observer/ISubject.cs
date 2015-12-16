using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Observer
{
    interface ISubject
    {
        void RegisterSubject(IObserver observer);
        void UnregisterSubject(IObserver observer);
        void NotifySubjects();
    }
}
