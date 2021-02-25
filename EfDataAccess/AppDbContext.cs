using Domain;
using EfDataAccess.DbConnection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfDataAccess
{
    public class AppDbContext : DbContext
    {
        private readonly IDbConnection _dbConnection;

        public AppDbContext(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public DbSet<Text> Text { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbConnection.ConnectionString);
        }
    }
}
