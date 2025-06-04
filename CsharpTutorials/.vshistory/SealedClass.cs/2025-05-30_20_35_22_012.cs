using CsharpTutorials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CsharpTutorials
{


    sealed class SealedClass 
    {
        public void Display()
        {
            Console.WriteLine("This is a Sealed Class");
        }
    }
     public class regularClass
    {
        public void Display()
        {
            Console.WriteLine("This is a regular NON Sealed Class");
        }
    }

    //public class DerivedClass : SealedClass
    public class DerivedClass : regularClass
    {
        // This will cause a compile-time error because SealedClass cannot be inherited.
        public void Show()
        {
            Console.WriteLine("This is a Derived Class");
        }
    }
}


//try this in the main programe
//     class Programe
//{
//    static void Main(string[] args)
//    {

//        DerivedClass derived = new DerivedClass();
//        derived.Display();

//        //Console.WriteLine("This is Main programe");
//    }
//}