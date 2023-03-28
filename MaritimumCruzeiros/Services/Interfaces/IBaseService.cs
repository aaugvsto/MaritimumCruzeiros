namespace MaritimumCruzeiros.Services.Interfaces
{
    public interface IBaseService<T>
    {
        Task<bool> CreateOrUpdate(T entity);
        Task<bool> Delete(int id);
        Task<T?> GetById(int id);
        Task<ICollection<T>?> GetAll();
    }
}
