using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Commands.TextCommands
{
    public interface IReadTextContentFile : ICommand<IFormFile, int>
    {
    }
}
