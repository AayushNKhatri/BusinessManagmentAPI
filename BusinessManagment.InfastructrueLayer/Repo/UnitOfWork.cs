using BusinessManagment.DomainLayer.Configuration;
using BusinessManagment.DomainLayer.RepoInterface;
using Microsoft.EntityFrameworkCore.Storage;

namespace BusinessManagment.InfastructrueLayer.Repo
{
    public class UnitOfWork(ApplicationDBContext db) : IUnitOfWork   //Using primary constructor to inject the ApplicationDBContext dependency
    {
        private readonly ApplicationDBContext _db = db;
        private IDbContextTransaction _transaction;

        public async Task BeginTranctionAsync()
        {
            _transaction = await _db.Database.BeginTransactionAsync();
        }

        public async Task CommitTranctionAsync()
        {
            if (_transaction == null) {
                throw new InvalidOperationException("No active transaction to commit.");
            }
            await _transaction.CommitAsync();
        }

        public async Task RollBackTranctionAsync()
        {
            if (_transaction == null) {
                throw new InvalidOperationException("No active transaction to rollback.");
            }
            await _transaction.RollbackAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
