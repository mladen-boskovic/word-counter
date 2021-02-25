using System;
using System.Collections.Generic;
using System.Text;

namespace EfDataAccess.DbConnection
{
    public interface IDbConnection
    {
        string ConnectionString { get; }
    }
}
