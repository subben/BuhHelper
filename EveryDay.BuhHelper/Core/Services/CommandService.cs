using EveryDay.BuhHelper.Console.Commands;
using EveryDay.BuhHelper.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EveryDay.BuhHelper.Console.Services
{
    public class CommandService : ICommandService
    {
        public ICommandResult ExecCommand(string name, string arg)
        {
            throw new NotImplementedException();
        }

        public List<ICommand> GetCommands()
        {
            var list = new List<ICommand>();

            list.Add(new KonturINNCommand());
            list.Add(new CountWorkDayInMonth());

            // загрузка какой-то dll
            var assembly = Assembly.LoadFrom($"{Environment.CurrentDirectory}\\Ext\\OtherCommand.dll");

            // загрузка всех классов из этой dll
            var classes = assembly.GetTypes();

            var typeCommand = typeof(ICommand);

            // перебрать все классы
            foreach (var item in classes)
            {
                if (item.IsAbstract || item.IsInterface)
                    continue;

                // выбрать те, которые реализую интерфес ICommand
                // получаем все интерфейсы
                var inters = item.GetInterfaces();

                // перебираем их
                //находим с нужным именем
                var comInterface = inters.FirstOrDefault(i => i == typeCommand);

                if (comInterface != null)
                {
                    // создать экземпляр класса
                    // (new CountWorkDayInMonth())
                    // Activator.CreateInstance<CountWorkDayInMonth>()

                    var instCommand = Activator.CreateInstance(item) as ICommand;

                    // добавить его в список
                    list.Add(instCommand);
                }

            }

            return list;
        }
    }
}
