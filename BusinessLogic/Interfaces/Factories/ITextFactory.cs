using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces.Factories
{
    public interface ITextFactory
    {
        int ReadText(TextDto dto);
    }
}
