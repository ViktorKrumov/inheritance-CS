using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBul = new StringBuilder();
            stringBul.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
            return stringBul.ToString();
        }
    }
}
