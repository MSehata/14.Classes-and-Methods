using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Classes_and_Methods
{
    internal class Student
    {
        public double weight;
        public string name;
        public int age;

        public Student(double aWeight, string aName, int anAge)
        {
            this.weight = aWeight;
            this.name = aName;
            this.age = anAge;
        }

        public bool isObese() 
        {           
            if (weight > 60)
                return true;
            else return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(70.6, "Jack", 22);
            Student student2 = new Student(56.7, "Tom", 24);

            Console.WriteLine("Student with the name " + student1.name + " is Obese. " + student1.isObese());
            Console.WriteLine("Student with the name " + student2.name + " is Obese. " + student2.isObese());
        }
    }
}
