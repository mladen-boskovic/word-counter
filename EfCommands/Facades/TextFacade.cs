using BusinessLogic.Enums;
using BusinessLogic.Interfaces.Facades;
using BusinessLogic.Interfaces.Factories;
using EfCommands.Factories.TextFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands.Facades
{
    public class TextFacade : ITextFacade
    {
        public ITextFactory GetTextFactory(ReadSource type)
        {
            ITextFactory textFactory = null;

            switch (type)
            {
                case ReadSource.Db:
                    textFactory =  new DbTextFactory();
                    break;
                case ReadSource.File:
                    textFactory =  new FileTextFactory();
                    break;
                case ReadSource.Input:
                    textFactory =  new InputTextFactory();
                    break;
            }

            return textFactory;
        }
    }
}
