using PrimaryConstructor.WebApi.Core.Interfaces;
using PrimaryConstructor.WebApi.Core.Models;

namespace PrimaryConstructor.WebApi.Services
{
    public class UserService : IUserService
    {
        public List<User> Users = new List<User>()
        {
            new User()
            {
                Id = 1,
                Name = "kaan",
                Email = "gmail.com",
            },
            new User()
            {
                Id = 1,
                Name = "kaan",
                Email = "gmail.com",
            },
        };

        public List<User> GetAllUsers()
        {
            return Users;
        }

        public User GetByIdUser(int id)
        {
            var user = Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public void NewUser(User user)
        {
            Users.Add(user);
        }
    }
}
