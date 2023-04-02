using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    class Child : Person
    {

        public Person Mother { get; set; }

        public Person Father { get; set; }

        public Child(string name, int age, Person mother, Person father) : base(name, age)
        {
            this.Mother = mother;
            this.Father = father;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(String.Format(base.ToString() + $" Mother:  {Mother.Name}" + $" Father: {Father.Name}"));
            return output.ToString();
        }
    }
}
