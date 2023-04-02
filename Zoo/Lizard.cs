using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceEx2
{
    class Lizard : Reptile
    {
        public Lizard(string name) : base(name)
        {
            this.Name = name;
        }
    }
}
