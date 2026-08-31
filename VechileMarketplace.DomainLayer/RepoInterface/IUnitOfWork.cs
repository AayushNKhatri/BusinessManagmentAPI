namespace BusinessManagment.DomainLayer.RepoInterface
{
    public interface IUnitOfWork
    {
        Task BeginTranctionAsync();
        Task CommitTranctionAsync();
        Task RollBackTranctionAsync();
        Task SaveChangesAsync();
    }
}
