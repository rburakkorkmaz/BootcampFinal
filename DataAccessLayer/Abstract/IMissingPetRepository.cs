using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IMissingPetRepository : IRepository<MissingPet>
    {
        Task<DateTime?> GetMissingDate(int id);
        Task<User?> GetOwner(int id);
        Task<string?> GetMissingAddress(int id);
        Task<string?> GetDescription(int id);

    }
}
