using BusinessLogic.Interfaces.Repositories;
using Domain;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfCommands.Repositories
{
    public class TextRepository : EfRepository<Text>, ITextRepository
    {
        public TextRepository(AppDbContext context) : base(context)
        {
        }
    }
}
