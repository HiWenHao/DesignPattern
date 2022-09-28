using System.Collections.Generic;

namespace DesignPattern.ObserverPattern
{
    public abstract class Subject
    {
        private List<Observer> Observers = new List<Observer>();
        public void AddObserver(Observer observer)
        {
            Observers.Add(observer);
        }
        public void RemoveObserver(Observer observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in Observers)
            {
                item.BeNotified();
            }
        }
    }

    public class SubjectItem1 : Subject
    {
        public int Age { get; set; } = 18;
    }
}
