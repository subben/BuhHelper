using EveryDay.BuhHelper.Console.Models;
using System;

namespace OtherCommand
{
    public class BlueCommand : EveryDay.BuhHelper.Console.Models.ICommand
    {
        public string Name => "blue";

        public ICommandResult Exec(string arg)
        {
            var result = new CommandResult();

            Console.ForegroundColor = ConsoleColor.Blue;

            result.Success = true;
            result.Result = "Цвет изменен на Синий";

            return result;
        }
    }
}
