using System;
using CsharpTutorials;


namespace CsharpTutorials
{
    class Programe
    {
        static void Main(string[] args)
        {

            //DerivedClass derived = new DerivedClass();
            //derived.Display();
            //derived.Show();

            //Console.WriteLine("This is Main programe");

            Student student = new Student();
            student.Name = "Test";
            student.Id = 101;
            student.Field = "Biology";
            student.displayInfo();
        }
    }
}

