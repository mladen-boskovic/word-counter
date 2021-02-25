using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EfCommands.Factories.TextFactory
{
    public class FileTextFactory : TextFactory
    {
        public override int ReadText(TextDto dto)
        {
            var stream = dto.File.OpenReadStream();
            var streamReader = new StreamReader(stream);
            var text = streamReader.ReadToEnd();

            stream.Close();
            streamReader.Close();

            return CountWords(text ?? "");
        }
    }
}
