using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class Full : AnimalState
    {
        public override void ChangeState(Animal animal)
        {
            animal.State = new Hungry();
            if(animal.CurrentHealth > 0)
            {
                animal.CurrentHealth--;
            }
        }

        public override string ToString()
        {
            return "Сытый";
        }
    }
}
