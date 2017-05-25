using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_ZooProject
{
    class MenuAnimal : ICommand
    {
        public void Execute(Zoo zoo)
        {
            Console.Clear();
            Console.WriteLine("1 - Добавить животное");
            Console.WriteLine("2 - Кормить животное");
            Console.WriteLine("3 - Лечить животное");
            Console.WriteLine("4 - Удалить животное");
            Console.WriteLine("5 - Запустить таймер");
            Console.Write("Выберите действие: ");
            ICommand command;
            do
            {
                string temp = Console.ReadLine();
                int selection = int.Parse(temp);
                switch (selection)
                {
                    case 1:
                        command = new CreateAnimal();
                        command.Execute(zoo);
                        break;
                    case 2:
                        command = new FeedAnimal();
                        command.Execute(zoo);
                        break;
                    case 3:
                        command = new HealAnimal();
                        command.Execute(zoo);
                        break;
                    case 4:
                        command = new DeleleAnimal();
                        command.Execute(zoo);
                        break;
                    case 5:
                        command = new ShowAnimal();
                        command.Execute(zoo);
                        break;
                    default:
                        Console.WriteLine("Попробуйте снова!");
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
    }
}
