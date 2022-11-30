using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Abstract;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly BackendContext _context;
        public GenericRepository()
        {
            _context = new BackendContext();
        }
        public async Task<bool> Save()
        {
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }
        public async Task<bool> Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await GetById(id);
            entity.IsDeleted = true;
            _context.Update<T>(entity);
            return await Save();
        }

        public async Task<bool> Delete(T entity)
        {
            _context.Update<T>(entity);
            return await Save();
        }

        public List<T> GetAll()
        {
            var result = _context.Set<T>().ToList();
            return result.Where(x => x.IsDeleted != true).ToList();
        }

        public async Task<T?> GetById(int id)
        {
            var result = await _context.Set<T>().FindAsync(id);

            if (result == null || result.IsDeleted) return null;

            return result;
        }

        public async Task<bool> Update(int id)
        {
            _context.Update<T>(await GetById(id));
            return await Save();
        }
        public async Task<bool> Update(T entity)
        {
            _context.Update<T>(entity);
            return await Save();
        }

    }
}
