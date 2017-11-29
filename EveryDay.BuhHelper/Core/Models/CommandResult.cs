namespace EveryDay.BuhHelper.Console.Models
{
    /// <summary>
    /// Результат выполнения команды
    /// </summary>
    public class CommandResult : ICommandResult
    {
        public string Result { get; set; }
        
        public string Error { get; set; } 

        public bool Success { get; set; }
    }
}
