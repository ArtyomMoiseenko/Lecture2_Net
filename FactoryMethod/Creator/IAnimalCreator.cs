using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    interface IAnimalCreator
    {
        Animal Create(string name);
    }
}
