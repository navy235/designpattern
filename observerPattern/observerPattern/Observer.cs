using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace observerPattern
{
    public abstract class Observer
    {

        public Observer()
        {
            this.SubjectCollection = new HashSet<Subject>();
        }

        public string Name
        {
            get;
            set;
        }

        public virtual void Display()
        {

        }


        public void Subscribe(Subject subject)
        {
            this.SubjectCollection.Add(subject);
            subject.Attach(this);
        }

        public void UnSubscribe(Subject subject)
        {
            this.SubjectCollection.Remove(subject);
            subject.Detach(this);
        }

        public ICollection<Subject> SubjectCollection { get; set; }
    }
}
