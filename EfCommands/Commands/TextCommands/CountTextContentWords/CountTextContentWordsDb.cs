using BusinessLogic.Commands.TextCommands;
using BusinessLogic.DTOs;
using BusinessLogic.Enums;
using BusinessLogic.Exceptions;
using BusinessLogic.Interfaces.Facades;
using BusinessLogic.Interfaces.Repositories;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands.Commands.TextCommands.CountTextContentWords
{
    public class CountTextContentWordsDb : IReadTextContentDb
    {
        private readonly ITextRepository _repository;
        private readonly ITextFacade _textFacade;

        public CountTextContentWordsDb(ITextRepository repository, ITextFacade textFacade)
        {
            _repository = repository;
            _textFacade = textFacade;
        }

        public int Execute(int request)
        {
            var text = _repository.GetById(request);

            if (text == null)
            {
                throw new EntityNotFoundException("Text");
            }

            var dbTextFactory = _textFacade.GetTextFactory(ReadSource.Db);
            return dbTextFactory.ReadText(new TextDto { Content = text.Content });
        }
    }
}
