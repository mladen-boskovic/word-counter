using BusinessLogic.Commands.TextCommands;
using BusinessLogic.Exceptions;
using BusinessLogic.Interfaces.Facades;
using BusinessLogic.Interfaces.Repositories;
using EfCommands.Commands.TextCommands.CountTextContentWords;
using EfCommands.Facades;
using EfCommands.Repositories;
using EfDataAccess;
using EfDataAccess.DbConnection;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTests
{
    public class WordCounterTests
    {
        private readonly ITextFacade _textFacade = new TextFacade();
        private readonly IDbConnection _dbConnection = new SqlServerDbConnection();

        private readonly AppDbContext Context;
        private readonly ITextRepository _textRepository;
        private readonly IReadTextContentDb _dbReader;
        private readonly IReadTextContentInput _inputReader;

        public WordCounterTests()
        {
            Context = new AppDbContext(_dbConnection);
            _textRepository = new TextRepository(Context);
            _dbReader = new CountTextContentWordsDb(_textRepository, _textFacade);
            _inputReader = new CountTextContentWordsInput(_textFacade);
        }

        [Fact]
        public void CountFromDb_IfEntityExists()
        {
            _dbReader.Execute(1).Should().Be(4);
        }

        [Fact]
        public void CountFromDb_IfEntityDoesNotExist()
        {
            _dbReader.Invoking(x => x.Execute(0)).Should().Throw<EntityNotFoundException>().WithMessage("Text not found.");
        }

        [Fact]
        public void CountFromInput_IfValueIsNotWhiteSpace()
        {
            _inputReader.Execute("This is some text").Should().Be(4);
        }

        [Fact]
        public void CountFromInput_IfValueIsWhiteSpace()
        {
            _inputReader.Execute("     ").Should().Be(0);
        }
    }
}
