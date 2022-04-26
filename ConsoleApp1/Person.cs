using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public abstract class Notebook
    {
        public abstract void Getnb();

    }
    public class Dell:Notebook
    {
        public override void Getnb()
        {
            Console.WriteLine("我是戴尔电脑");
        }
    }
    public class Lenove : Notebook
    {
        public override void Getnb()
        {
            Console.WriteLine("我是联想电脑");
        }
    }
    public class Help : Notebook
    {
        public override void Getnb()
        {
            Console.WriteLine("我是惠普电脑");
        }
    }
}
