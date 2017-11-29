using EveryDay.BuhHelper.Console.Models;
using System;

namespace OtherCommand
{
    public class RedCommand : EveryDay.BuhHelper.Console.Models.ICommand, ICommand
    {
        public string Name => "red";

        public string Test => "red test";

        public ICommandResult Exec(string arg)
        {
            var result = new CommandResult();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;


            result.Success = true;
            result.Result = "Цвет изменен на красный";

            return result;
        }
    }
}
