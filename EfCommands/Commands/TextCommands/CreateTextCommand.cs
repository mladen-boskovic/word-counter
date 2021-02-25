using BusinessLogic.Commands.TextCommands;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands.Commands.TextCommands
{
    public class CreateTextCommand : ICreateTextCommand
    {
        private ITextRepository _repository;

        public CreateTextCommand(ITextRepository repository)
        {
            _repository = repository;
        }

        public void Execute(TextDto request)
        {
            _repository.Create(new Text
            {
                Content = request.Content
            });
        }
    }
}
