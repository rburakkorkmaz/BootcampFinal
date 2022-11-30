using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {

        public bool? CheckAccountLogin(string username, string password)
        {
            var result = GetAll().First(x => x.Username == username);
            return result.Password == password;
        }

        public async Task<string?> GetAddress(int id)
        {
            var result = await GetById(id);
            return result != null ? result.Address : null;
        }
        public async Task<string?> GetUsername(int id)
        {
            var result = await GetById(id);
            return result != null ? result.Username : null;
        }

        public async Task<string?> GetPassword(int id)
        {
            var result = await GetById(id);
            return result != null ? result.Password : null;
        }

        public async Task<IEnumerable<Pet>?> GetPets(int id)
        {
            var result = await GetById(id);
            return result != null ? result.Pets : null;
        }

        public async Task<int?> GetPetsFound(int id)
        {
            var result = await GetById(id);
            return result != null ? result.PetsFound : null;
        }

        public async Task<string?> GetPhoneNumber(int id)
        {
            var result = await GetById(id);
            return result != null ? result.PhoneNumber : null;
        }


    }
}
