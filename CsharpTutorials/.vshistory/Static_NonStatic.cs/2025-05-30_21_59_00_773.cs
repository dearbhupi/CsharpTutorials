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

        public void displayInfo() 
        {
            Console.WriteLine($"Student Name is {Name} and id is {Id} and studing in field :{Field}");
        }
    
    }


}
