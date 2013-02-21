using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace observerPatternEvent
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

        public virtual void Display(Object sender, EventArgs e)
        {

        }

        public void Subscribe(Subject subject)
        {
            this.SubjectCollection.Add(subject);
            subject.MessageChanged += Display;
        }

        public void UnSubscribe(Subject subject)
        {
            this.SubjectCollection.Remove(subject);
            subject.MessageChanged -= Display;
        }

        public ICollection<Subject> SubjectCollection { get; set; }

    }
}
