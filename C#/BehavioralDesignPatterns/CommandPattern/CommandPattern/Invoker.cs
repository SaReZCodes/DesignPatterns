using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Invoker
    {
        ICommand _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ButtonWasPressed()
        {
            _command.Execute();
        }
    }
}
