using BusinessLogic.Commands.TextCommands;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfCommands.Commands.TextCommands
{
    public class GetAllTextsCommand : IGetAllTextsCommand
    {
        private ITextRepository _repository;

        public GetAllTextsCommand(ITextRepository repository)
        {
            _repository = repository;
        }

        public List<TextDto> Execute()
        {
            var texts = _repository.GetAll();
            return texts.Select(x => new TextDto
            {
                Id = x.Id,
                Content = x.Content
            }).ToList();
        }
    }
}
