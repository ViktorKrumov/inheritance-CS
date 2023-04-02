using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceEx2
{
    class Bear : Mammal
    {
        public Bear(string name) : base(name)
        {
            this.Name = name;
        }
    }
}
