using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class Sick : AnimalState
    {
        public override void ChangeState(Animal animal)
        {
            animal.State = new Dead();
            if (animal.CurrentHealth > 0)
            {
                animal.CurrentHealth--;
            }
        }
        public override string ToString()
        {
            return "Болен";
        }
    }
}
