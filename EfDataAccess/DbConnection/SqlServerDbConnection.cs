using System;
using System.Collections.Generic;
using System.Text;

namespace EfDataAccess.DbConnection
{
    public class SqlServerDbConnection : IDbConnection
    {
        public string ConnectionString => @"Data Source=MLADEN\SQLEXPRESS;Initial Catalog=IODB;Integrated Security=True";
    }
}
