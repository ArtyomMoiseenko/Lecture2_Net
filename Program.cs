using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            ICommand start = new MenuAnimal();
            start.Execute(zoo);         
        }
    }
}
