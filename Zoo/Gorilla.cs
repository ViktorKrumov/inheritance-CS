using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceEx2
{
    class Gorilla : Mammal
    {
        public Gorilla(string name) : base(name)
        {
            this.Name = name;
        }
    }
}
