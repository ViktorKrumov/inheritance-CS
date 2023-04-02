using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceEx2
{
    class Snake : Reptile
    {

        public Snake(string name) : base(name)
        {
            this.Name = name;
        }
    }
}
