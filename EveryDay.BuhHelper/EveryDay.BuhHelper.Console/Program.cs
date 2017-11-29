using EveryDay.BuhHelper.Console.Models;
using EveryDay.BuhHelper.Console.Services;
using System.Linq;

namespace EveryDay.BuhHelper
{
    class Program
    {
        static ICommandService CommandService { get; set; }

        static void Main(string[] args)
        {
            CommandService = new CommandService();

            // получить список команд
            var commands = CommandService.GetCommands();

            // вывести их на экран
            System.Console.WriteLine("Выберите № команды: ");
            for (int i = 0; i < commands.Count; i++)
            {
                // "0. команда"
                System.Console.WriteLine($"{i+1}. {commands[i].Name}");
            }
            
            // получаем ввод пользователя
            var select = System.Console.ReadLine();

            // определяем выбранную команду
            // лямда-выражение
            // делегаты
            int id = -1;
            ICommand selectCommand = null;
            if (int.TryParse(select, out id))
            {
                if (--id >= 0)
                {
                    selectCommand = commands[id];
                }
            }
            else
            {
                selectCommand = commands.FirstOrDefault(c => c.Name == select);
            }

            if (selectCommand == null)
            {
                // выводим пользователю ошибку
                System.Console.WriteLine("Вы ошиблись в названии команды");
            }
            else
            {
                // выполянем команду
                System.Console.WriteLine("Введите параметры: ");
                var input = System.Console.ReadLine();
                var result = selectCommand.Exec(input);
                // выводим пользователю результат или ошибку
                System.Console.WriteLine(result.Success ? result.Result : result.Error);

            }
            System.Console.ReadKey();
        }
    }


}
