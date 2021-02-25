using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Commands.TextCommands
{
    public interface ICreateTextCommand : ICommandRequest<TextDto>
    {
    }
}
