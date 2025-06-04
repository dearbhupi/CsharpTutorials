using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorials
{
    public class Student

    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Field { get; set; }

        private int age { get; set; }

        static string City = "OSU"; 

        public void displayInfo() 
        {
            Console.WriteLine($"Student Name is {Name} and id is {Id} and studing in field :{Field}");
        }

        public static void displayCity()
        {
            Console.WriteLine($"Student is from {City}");
        }

    }
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
           // student.City = "New York"; // 'Student.City' is inaccessible due to its protection level
            //student.age = 33; // 'Student.age' is inaccessible due to its protection level
            student.displayInfo();

            Student.displayCity(); // Calling static method to display city

            Student student1 = new Student();
            student1.Name = "Alpha";
            student1.Id = 102;
            student1.Field = "Chemistry";
            student1.displayInfo();

            Student.displayCity(); // Calling static method to display city
        }
    }


}
