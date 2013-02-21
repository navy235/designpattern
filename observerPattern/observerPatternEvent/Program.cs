using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPatternEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat ct = new Cat("猫", "睡着的");
            BlackCat ct1 = new BlackCat("黑猫", "睡着的");
            Mouse mo = new Mouse("小老鼠");
            mo.Subscribe(ct);
            mo.Subscribe(ct1);
            ct.Change("睡醒了，饿了");
            mo.UnSubscribe(ct);
            ct1.Change("继续睡");
            Console.ReadLine();
        }
    }
}
