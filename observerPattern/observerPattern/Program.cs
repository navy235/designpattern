using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat ct = new Cat("猫", "睡着的");
            Mouse mo = new Mouse("小老鼠");
            mo.Subscribe(ct);
            ct.Change();
            Console.ReadLine();
        }
    }
}
