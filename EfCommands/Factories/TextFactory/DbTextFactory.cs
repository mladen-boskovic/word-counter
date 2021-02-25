using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands.Factories.TextFactory
{
    public class DbTextFactory : TextFactory
    {
        public override int ReadText(TextDto dto)
        {
            return CountWords(dto.Content ?? "");
        }
    }
}
