using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPatternEvent
{
    public class Cat : Subject
    {
        public Cat(string name, string message)
        {
            this.Name = name;
            this.Message = message;
            Console.WriteLine(this.Name + "信息:" + this.Message);
        }

    }
}
