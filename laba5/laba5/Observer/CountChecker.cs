using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Observer
{
   public class CountChecker : ISubject
    {
        int countOfZoos;
        List<IObserver> observers;
        public CountChecker()
        {
            observers = new List<IObserver>();
        }
        public void IncrementTheCount()
        {
            countOfZoos++;
            NotifySubjects();
        }
        public void DecrementTheCount()
        {
            countOfZoos--;
            NotifySubjects();
        }
        public void NotifySubjects()
        {
            if(observers.Count != 0) {
            foreach(IObserver observer in observers)
            {
                observer.UpdateCount(countOfZoos);
            }
            }
        }
        public void RegisterSubject(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterSubject(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
