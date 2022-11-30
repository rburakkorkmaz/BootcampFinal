using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IFoundPetRepository : IRepository<FoundPet>
    {
        Task<User?> GetFinder(int id);
        Task<DateTime?> GetFindingDate(int id);
        Task<string?> GetFoundAddress(int id);
        Task<string?> GetDescription(int id);

    }
}
