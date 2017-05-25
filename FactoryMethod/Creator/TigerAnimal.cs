using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class TigerAnimal : IAnimalCreator
    {
        public Animal Create(string name)
        {
            return new Tiger(name);
        }
    }
}
