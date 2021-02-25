using BusinessLogic.Commands.TextCommands;
using BusinessLogic.DTOs;
using BusinessLogic.Enums;
using BusinessLogic.Helpers;
using BusinessLogic.Interfaces.Facades;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EfCommands.Commands.TextCommands.CountTextContentWords
{
    public class CountTextContentWordsFile : IReadTextContentFile
    {
        private readonly ITextFacade _textFacade;

        public CountTextContentWordsFile(ITextFacade textFacade)
        {
            _textFacade = textFacade;
        }

        public int Execute(IFormFile request)
        {
            if (request == null)
            {
                throw new NullReferenceException("Please upload a file first.");
            }

            var extension = Path.GetExtension(request.FileName);

            if (!FileUpload.AllowedExtensions.Contains(extension))
            {
                throw new Exception($"Please upload a file with one of the following extensions: {string.Join(", ", FileUpload.AllowedExtensions)}");
            }

            var fileTextFactory = _textFacade.GetTextFactory(ReadSource.File);
            return fileTextFactory.ReadText(new TextDto { File = request });
        }
    }
}
