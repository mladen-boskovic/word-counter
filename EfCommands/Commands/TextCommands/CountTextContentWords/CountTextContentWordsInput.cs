using BusinessLogic.Commands.TextCommands;
using BusinessLogic.DTOs;
using BusinessLogic.Enums;
using BusinessLogic.Interfaces.Facades;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands.Commands.TextCommands.CountTextContentWords
{
    public class CountTextContentWordsInput : IReadTextContentInput
    {
        private readonly ITextFacade _textFacade;

        public CountTextContentWordsInput(ITextFacade textFacade)
        {
            _textFacade = textFacade;
        }

        public int Execute(string request)
        {
            var inputTextFactory = _textFacade.GetTextFactory(ReadSource.Input);
            return inputTextFactory.ReadText(new TextDto { Input = request });
        }
    }
}
