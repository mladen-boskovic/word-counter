using BusinessLogic.DTOs;
using BusinessLogic.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands.Factories.TextFactory
{
    public abstract class TextFactory : ITextFactory
    {
        private char[] delimiters = new char[] { ' ', '\r', '\n' };

        protected int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }

            return text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public abstract int ReadText(TextDto dto);
    }
}
