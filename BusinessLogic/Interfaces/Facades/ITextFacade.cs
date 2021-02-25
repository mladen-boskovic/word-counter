using BusinessLogic.Enums;
using BusinessLogic.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces.Facades
{
    public interface ITextFacade
    {
        ITextFactory GetTextFactory(ReadSource type);
    }
}
