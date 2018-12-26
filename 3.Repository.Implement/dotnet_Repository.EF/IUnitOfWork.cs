
using dotnet_Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_Repository.EF
{
    public interface IUnitOfWork : IDisposable, IDependency
    {
        bool AutoCommit { get; set; }
       // DbContextTransaction UseTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadUncommitted);
        //long GenerateEventNo();
        //void Rollback();
        int Commit();
        int ExecuteSqlCommand(string sql, params object[] args);
       // DbRawSqlQuery<TElement> SqlQuery<TElement>(string sql, params object[] args);
       // string GenerateNcId(string idHeader, int v);
    }
}
