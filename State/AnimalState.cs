using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    abstract class AnimalState
    {
        public abstract void ChangeState(Animal animal);

        public virtual void Feed(Animal animal) { }

        public void Heal(Animal animal)
        {
            if (animal.CurrentHealth < animal.Health && animal.CurrentHealth > 0)
            {
                animal.CurrentHealth++;
            }
        }
    }
}
