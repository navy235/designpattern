using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPattern
{
    public class Cat : Subject
    {
        public Cat(string name, string message)
        {
            this.Name = name;
            this.Message = message;
            Console.WriteLine(this.Name + "信息:" + this.Message);
        }

        public void Change()
        {
            this.Message = "饿了，醒来了";
            foreach (var o in this.ObserverCollecion)
            {
                o.Display();
            }
        }
    }
}
