using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class Zoo
    {
        public List<Animal> ListAliveAnimals { get; set; } = new List<Animal>();
        public List<Animal> ListDeadAnimals { get; set; } = new List<Animal>();
    }
}
