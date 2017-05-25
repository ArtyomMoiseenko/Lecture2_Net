using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class Elephant : Animal
    {
        public Elephant(string name)
            : base(name)
        {
            Health = 7;
            CurrentHealth = Health;
        }

        public override string ToString()
        {
            return "Слон";
        }
    }
}
