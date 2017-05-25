using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lecture2_ZooProject
{
    class ShowAnimal : ICommand
    {
        private bool _keyPress = false;

        private void KeyPress()
        {
            Console.ReadKey();
            _keyPress = true;
        }

        public void Execute(Zoo zoo)
        {
            Thread thread = new Thread(KeyPress);
            Random random = new Random();
            int time = 0;
            thread.Start();
            while (zoo.ListAliveAnimals.Count > 0)
            {
                if (_keyPress)
                {
                    thread.Abort();
                    break;
                }
                if (time == 5)
                {
                    zoo.ListAliveAnimals[random.Next(0, zoo.ListAliveAnimals.Count)]?.ChangeState();
                    zoo.ListAliveAnimals.RemoveAll(item => item.State.ToString() == "Мёртв");
                    time = 0;
                }
                Console.Clear();
                Console.WriteLine("Имя\tТип\tСостояние\tЗдоровье");
                foreach (var item in zoo.ListAliveAnimals)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t\t{3}", item.Name, item, item.State, item.CurrentHealth);
                }
                Console.WriteLine(DateTimeOffset.Now.ToString("T"));
                Console.WriteLine("Введите любой символ для выхода");
                time++;
                Thread.Sleep(1000);
            }
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("Введите любой символ для выхода");
                Console.Clear();
                new MenuAnimal().Execute(zoo);
            }
        }
    }
}
