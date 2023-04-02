using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceEx2
{
    public class Reptile : Animal
    {
        public Reptile(string name) : base(name)
        {
            this.Name = name;
        }
    }
}
