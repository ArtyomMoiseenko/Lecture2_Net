using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class Dead : AnimalState
    {
        public override void ChangeState(Animal animal)
        {
            animal.State = new Dead();
        }

        public override string ToString()
        {
            return "Мёртв";
        }
    }
}
