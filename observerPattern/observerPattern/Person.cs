using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPattern
{
    public class Person : Observer
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public override void Display()
        {
            Console.WriteLine(this.Name + "：订阅详情");
            foreach (var s in this.SubjectCollection)
            {
                Console.WriteLine("订阅者:" + s.Name + "，订阅信息：" + s.Message);
            }
            SelfAction();
        }

        public void SelfAction()
        {
            Console.WriteLine("该死的猫吵死了");
        }
    }
}
