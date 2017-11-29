using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherCommand
{
    public class Test : ICommand
    {
        string ICommand.Test
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
