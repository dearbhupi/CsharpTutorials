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
        public sealed override void Display()
        {
            Console.WriteLine("Display from class B, Important to NOTE the sealed method only work on a inherited virtual method of parent using override method only");
            Console.WriteLine("We can not make a sealed method in the parent class");
        }

    }
    internal class C : B
    {
        // This method cannot be overridden because it is sealed in class B
        //public override void Display()
        //{
        //    Console.WriteLine("Display from class C");
        //}

    }
}