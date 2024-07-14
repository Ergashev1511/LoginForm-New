using LoginForm.Data.Repositories;
using LoginForm.Models;

namespace LoginForm.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<bool> Login(string username, string password)
    {
        var user= await _repository.Login(username, password);
        return user != null;
    }

    public async Task<User> AddUser(User user)
    {
        if (user == null) throw new Exception("User model mustn't be null");
        User users = new User()
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            UserName = user.UserName,
            Password = user.Password
        };
        await _repository.AddUser(users);
        return user;
    }
}