using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace observerPatternEvent
{
    public abstract class Subject
    {

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

        public event EventHandler MessageChanged;

        public virtual void Change(string message)
        {
            this.Message = message;
            if (MessageChanged != null)
                MessageChanged(this, EventArgs.Empty);
        }
    }
}
