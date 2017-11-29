using EveryDay.BuhHelper.Console.Models;
using System;

namespace EveryDay.BuhHelper.Console.Commands
{
    public class CountWorkDayInMonth : ICommand
    {
        public string Name => "cwdim";

        public ICommandResult Exec(string arg)
        {
            var result = new CommandResult();

            var now = DateTime.Now;

            var days = DateTime.DaysInMonth(now.Year, now.Month) - 8;

            result.Result = $"{days}";

            result.Success = true;

            return result;
        }
    }
}
