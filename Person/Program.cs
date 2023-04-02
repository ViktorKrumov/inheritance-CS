using System;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string childName = Console.ReadLine();
            int childAge = int.Parse(Console.ReadLine());

            string motherName = Console.ReadLine();
            int motherAGe = int.Parse(Console.ReadLine());

            string fatherName = Console.ReadLine();
            int fatherAge = int.Parse(Console.ReadLine());

            var mother = new Person(motherName, motherAGe);
            var father = new Person(fatherName, fatherAge);
            var child = new Child(childName, childAge, mother, father);
            Console.WriteLine(child.ToString());
        }
    }
}
