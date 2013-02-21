using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPattern
{
    public class Mouse : Observer
    {
        public Mouse(string name)
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
            Console.WriteLine("快跑！");
        }
    }
}
