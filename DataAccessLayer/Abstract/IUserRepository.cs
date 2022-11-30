using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        bool? CheckAccountLogin(string username, string password);
        Task<string?> GetUsername(int id);
        Task<string?> GetPassword(int id);
        Task<string?> GetPhoneNumber(int id);
        Task<string?> GetAddress(int id);
        Task<int?> GetPetsFound(int id);
        Task<IEnumerable<Pet>?> GetPets(int id);



    }
}
