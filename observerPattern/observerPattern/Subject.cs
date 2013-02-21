using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace observerPattern
{
    public abstract class Subject
    {
        public Subject()
        {
            this.ObserverCollecion = new HashSet<Observer>();
        }

        public string Name
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }

        public void Attach(Observer observer)
        {
            this.ObserverCollecion.Add(observer);
        }

        public void Detach(Observer observer)
        {
            this.ObserverCollecion.Remove(observer);
        }

        public virtual void Change(string message)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Observer> ObserverCollecion { get; set; }
    }
}
