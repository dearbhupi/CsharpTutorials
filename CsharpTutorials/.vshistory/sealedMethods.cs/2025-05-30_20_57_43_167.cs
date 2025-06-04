using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorials
{
    internal class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Display from class A");
        }
    }
    internal class B : A
    {
        public override void Display()
        {
            Console.WriteLine("Display from class B");
        }
        public sealed void Show()
        {
            Console.WriteLine("Show from class B");
        }
    }
    internal class C : B
    {
        public override void Display()
        {
            Console.WriteLine("Display from class C");
        }
        //This will cause a compile-time error because Show is sealed in class B
         public override void Show()
        {
            Console.WriteLine("Show from class C");
        }
    }
    {
    }
}
