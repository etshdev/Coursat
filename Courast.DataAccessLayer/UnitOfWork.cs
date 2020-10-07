using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coursat.DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(CoursatDB CoursatDB) => this.CoursatDB = CoursatDB;

        public CoursatDB CoursatDB { get; }


        public IDbContextTransaction dbContextTransaction { get; set; }

        public void commit()
        {
            CoursatDB.Database.CurrentTransaction.Commit();
        }

        public void Dispose()
        {
            CoursatDB.Dispose();
        }

        public bool SaveChanges()
        {
            try
            {
                return CoursatDB.SaveChanges() > 0 ? true : false;
            }
            catch
            {

                return false;
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                return (await CoursatDB.SaveChangesAsync()) > 0 ? true : false;
            }
            catch
            {
                return false;
            }
        }
    }
}
