using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> GetById(int id)
        {
            return await _userRepository.GetById(id);
        }

        public bool? CheckAccountLogin(string username, string password)
        {
            return _userRepository.CheckAccountLogin(username, password);
        }

        public async Task<string?> GetAddress(int id)
        {
            return await _userRepository.GetAddress(id);
        }

        public async Task<string?> GetUsername(int id)
        {
            return await _userRepository.GetUsername(id);
        }

        public async Task<string?> GetPassword(int id)
        {
            return await _userRepository.GetPassword(id);
        }

        public async Task<IEnumerable<Pet>?> GetPets(int id)
        {
            return await _userRepository.GetPets(id);
        }

        public async Task<int?> GetPetsFound(int id)
        {
            return await _userRepository.GetPetsFound(id);
        }

        public async Task<string?> GetPhoneNumber(int id)
        {
            return await _userRepository.GetPhoneNumber(id);
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public async Task UserAdd(User user)
        {
            await _userRepository.Create(user);
        }

        public async Task UserDelete(User user)
        {
            await _userRepository.Delete(user);
        }

        public async Task UserDelete(int id)
        {
            await _userRepository.Delete(id);
        }

        public async Task UserUpdate(User user)
        {
            await _userRepository.Update(user);
        }

        public async Task<bool> Save()
        {
            return await _userRepository.Save();
        }
    }
}
