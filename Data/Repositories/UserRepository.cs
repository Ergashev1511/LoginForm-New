using LoginForm.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginForm.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<User> Login(string username, string password)
    {
        var user = await _context.Users.FirstOrDefaultAsync(a =>
            !a.IsDeleted && a.UserName == username && a.Password == password);
        return user;
    }

    public async Task<User> AddUser(User user)
    {
        if (user == null) throw new ArgumentNullException("User model mustn't be null");
        else
        {
            var hascopy =
                await _context.Users.AnyAsync(a => a.UserName == user.UserName || a.Password == user.Password);
            if (hascopy) throw new Exception("User already exist!");
           
                await _context.AddRangeAsync(user);
                await _context.SaveChangesAsync();
        }

        return user;
    }
}