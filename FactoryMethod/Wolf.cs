using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class Wolf : Animal
    {
        public Wolf(string name)
            : base(name)
        {
            Health = 4;
            CurrentHealth = Health;
        }

        public override string ToString()
        {
            return "Волк";
        }
    }
}
