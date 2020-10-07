using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coursat.DataAccessLayer
{
    public interface IUnitOfWork : IDisposable
    {

        CoursatDB CoursatDB { get; }

        IDbContextTransaction dbContextTransaction { get; set; }

        void commit();

        bool SaveChanges();

        Task<bool> SaveChangesAsync();

    }
}
