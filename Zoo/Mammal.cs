using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceEx2
{
    class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
            this.Name = name;
        }
    }
}
