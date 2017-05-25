using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class DeleleAnimal : ICommand
    {
        public void Execute(Zoo zoo)
        {
            Console.Clear();
            Console.WriteLine("Удаление животного");
            Console.WriteLine("Введите имя животного:");
            Animal animal = null;
            while (animal == null)
            {
                string name = Console.ReadLine();
                animal = zoo.ListAliveAnimals.FirstOrDefault(x => x.Name == name && x.State.ToString() == "Мёртвый");
                if (animal == null)
                {
                    Console.WriteLine("Неверное имя. Введите имя животного: ");
                    continue;
                }
            }
            new MenuAnimal().Execute(zoo);
        }
    }
}
