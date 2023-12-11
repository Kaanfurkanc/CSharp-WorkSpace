using Microsoft.Extensions.Logging;

namespace PrimaryConstructorConsoleApp
{

    public sealed class UserService(int id, string name)
    {
        //private int Id { get;  } = id;
        //private string Name { get; } = name;

        public UserService() : this(0, "Default") { }
        public void PrintUser()
        {
            Console.WriteLine($"User id = {id}, User name = {name}");
        }
    }
}
