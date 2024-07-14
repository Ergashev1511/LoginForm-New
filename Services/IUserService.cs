using LoginForm.Models;

namespace LoginForm.Services;

public interface IUserService
{
    Task<bool> Login(string username, string password);
    Task<User> AddUser(User user);
}