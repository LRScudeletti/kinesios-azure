namespace KinesiOSAzureApi.Services;

using AutoMapper;
using BCrypt.Net;
using Entities;
using Helpers;
using Models.Users;

public interface IUserService
{
    void CreateUser(CreateUser createUser);
    IEnumerable<User>? ReadAllUsers();
    User ReadUserByUsername(string username);
    void DeleteUser(string username);
}

public class UserService : IUserService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public UserService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void CreateUser(CreateUser createUser)
    {
        // Validate
        if (_context.Users != null && _context.Users.Any(x => x.Username == createUser.Username))
            throw new AppException("Username '" + createUser.Username + "' already exists.");

        // Map createUser to new user object
        var user = _mapper.Map<User>(createUser);

        // Hash password
        user.UserPasswordHash = BCrypt.HashPassword(createUser.UserPassword);

        // Save user
        _context.Users?.Add(user);
        _context.SaveChanges();
    }

    public IEnumerable<User>? ReadAllUsers()
    {
        return _context.Users;
    }

    public User ReadUserByUsername(string username)
    {
        return GetUser(username);
    }

    public void DeleteUser(string username)
    {
        var user = GetUser(username);
        _context.Users?.Remove(user);
        _context.SaveChanges();
    }

    // Helper method
    private User GetUser(string username)
    {
        var user = _context.Users?.Find(username);
        if (user == null)
            throw new KeyNotFoundException("Username '" + username + "' not found.");

        return user;
    }
}