using LoginForm.Models;

namespace LoginForm.Data.Repositories;

public interface IUserRepository
{
    Task<User> Login(string username, string password);
    Task<User> AddUser(User user);
}