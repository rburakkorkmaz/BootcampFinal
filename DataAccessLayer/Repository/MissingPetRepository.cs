using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class MissingPetRepository : GenericRepository<MissingPet>, IMissingPetRepository
    {

        public async Task<string?> GetMissingAddress(int id)
        {
            var result = await GetById(id);
            return result != null ? result.LastSeenAddress : null;
        }

        public async Task<DateTime?> GetMissingDate(int id)
        {
            var result = await GetById(id);
            return result != null ? result.MissingDate : null;
        }

        public async Task<User?> GetOwner(int id)
        {
            var result = await GetById(id);
            return result != null ? result.User : null;
        }

        public async Task<string?> GetDescription(int id)
        {
            var result = await GetById(id);
            return result != null ? result.Description : null;
        }
    }
}
