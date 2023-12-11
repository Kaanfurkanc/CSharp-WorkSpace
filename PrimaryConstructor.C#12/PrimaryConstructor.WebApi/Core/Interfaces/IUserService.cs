using PrimaryConstructor.WebApi.Core.Models;

namespace PrimaryConstructor.WebApi.Core.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User GetByIdUser(int id);
        void NewUser(User user);
    }
}
