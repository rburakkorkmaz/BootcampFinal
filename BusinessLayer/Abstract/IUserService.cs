using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    internal interface IUserService
    {
        Task UserAdd(User user);
        Task UserDelete(User user);
        Task UserUpdate(User user);
        List<User> GetUsers();
        Task<User?> GetById(int id);
    }
}
