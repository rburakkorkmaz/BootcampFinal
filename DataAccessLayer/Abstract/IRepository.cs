using EntityLayer.Abstract;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        Task<T?> GetById(int id);
        //Task<T> GetWhere(Expression<Func<T, bool>> filter);
        Task<bool> Create(T entity);
        Task<bool> Update(int id);
        Task<bool> Update(T entity);
        Task<bool> Delete(int id);
        Task<bool> Delete(T entity);
        Task<bool> Save();



    }
}
