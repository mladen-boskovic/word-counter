using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands.Factories.TextFactory
{
    public class InputTextFactory : TextFactory
    {
        public override int ReadText(TextDto dto)
        {
            return CountWords(dto.Input ?? "");
        }
    }
}
