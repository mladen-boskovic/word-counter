using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Commands.TextCommands
{
    public interface IReadTextContentInput : ICommand<string, int>
    {
    }
}
