using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taav.Contracts;

namespace Library.Persistence.Ef
{
    internal class EfUnitOfWork : UnitOfWork
    {
        private readonly EfDataContext _context;

        public EfUnitOfWork(EfDataContext context)
        {
            this._context = context;
        }




        public async Task Begin()
        {
            await _context.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            await _context.Database.CommitTransactionAsync();
        }

        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Rollback()
        {
            await _context.Database.RollbackTransactionAsync();
        }
    }
}
