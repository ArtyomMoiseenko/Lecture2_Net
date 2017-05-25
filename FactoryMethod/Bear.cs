using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class Bear : Animal
    {
        public Bear(string name)
            : base(name)
        {
            Health = 6;
            CurrentHealth = Health;
        }

        public override string ToString()
        {
            return "Медведь";
        }
    }
}
