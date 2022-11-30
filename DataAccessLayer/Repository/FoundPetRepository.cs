using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class FoundPetRepository : GenericRepository<FoundPet>, IFoundPetRepository
    {

        public async Task<User?> GetFinder(int id)
        {
            var result = await GetById(id);
            return result != null ? result.User : null;
        }

        public async Task<DateTime?> GetFindingDate(int id)
        {
            var result = await GetById(id);
            return result != null ? result.FindingDate : null;
        }

        public async Task<string?> GetFoundAddress(int id)
        {
            var result = await GetById(id);
            return result != null ? result.FoundAddress : null;
        }

        public async Task<string?> GetDescription(int id)
        {
            var result = await GetById(id);
            return result != null ? result.Description : null;
        }
    }
}
