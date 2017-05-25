using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class Lion : Animal
    {
        public Lion(string name)
            : base(name)
        {
            Health = 5;
            CurrentHealth = Health;
        }

        public override string ToString()
        {
            return "Лев";
        }
    }
}
