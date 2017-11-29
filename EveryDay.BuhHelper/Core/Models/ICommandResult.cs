using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDay.BuhHelper.Console.Models
{
    /// <summary>
    /// Результат выполнения команды
    /// </summary>
    public interface ICommandResult
    {
        /// <summary>
        /// Результат
        /// </summary>
        string Result { get; set; }

        /// <summary>
        /// Ошибка
        /// </summary>
        string Error { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        bool Success { get; set; }
    }
}
