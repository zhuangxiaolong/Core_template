using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;

namespace dotnet_Repository.EF
{
    public class DbContextBase : DbContext, IUnitOfWork
    {
        //public DbContextBase(string connStr)
        //    : base(connStr)
        //{
        //    AutoCommit = true;
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=MusicStore;user id=sa;password=123;");
            }
        }

        private IDbContextTransaction _transaction;

        public bool AutoCommit { get; set; }
        public void Rollback()
        {
            if (_transaction != null)
                _transaction.Rollback();
        }

        public int Commit()
        {
            int result = 0;
            try
            {
                result = SaveChanges();
                if (_transaction != null)
                    _transaction.Commit();
            }
            catch (Exception ex)
            {
                //if (ObjectStateManager.GetObjectStateEntry(entity).State == EntityState.Deleted || ObjectStateManager.GetObjectStateEntry(entity).State == EntityState.Modified)
                //    this.Refresh(RefreshMode.StoreWins, entity);
                //else if (ObjectStateManager.GetObjectStateEntry(entity).State == EntityState.Added)
                //    Detach(entity);
                //AcceptAllChanges();
                //_transaction.Commit();
            }
            return result;
        }

        //public DbContextTransaction UseTransaction(IsolationLevel isolationLevel = IsolationLevel.RepeatableRead)
        //{
        //    AutoCommit = false;
        //    _transaction = Database.BeginTransaction(isolationLevel);
        //    return _transaction;
        //}

        public int ExecuteSqlCommand(string sql, params object[] args)
        {
            return Database.ExecuteSqlCommand(sql, args);
        }

        //public DbRawSqlQuery<TElement> SqlQuery<TElement>(string sql, params object[] args)
        //{
        //    return Database.SqlQuery<TElement>(sql, args);
        //}

        //public long GenerateEventNo()
        //{
        //    var eventNo = SqlQuery<long>("SELECT NEXT VALUE FOR SQ_EVENTNO").First();
        //    var eventStr = eventNo.ToString();
        //    while (eventStr.Length < 6)
        //    {
        //        eventStr = "0" + eventStr;
        //    }
        //    eventStr = string.Format("{0:yyMMdd}{1}", DateTime.Now, eventStr);
        //    return long.Parse(eventStr);
        //}
        public string GenerateNcId(string beginStr, int length)
        {
           
            {
                throw new Exception("生成ID失败");
            }
        }


    }
}
