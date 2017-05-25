using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class Hungry : AnimalState
    {
        public override void ChangeState(Animal animal)
        {
            animal.State = new Sick();
            if (animal.CurrentHealth > 0)
            {
                animal.CurrentHealth--;
            }
        }
        public override void Feed(Animal animal)
        {
            animal.State = new Full();
        }
        public override string ToString()
        {
            return "Голоден";
        }
    }
}
