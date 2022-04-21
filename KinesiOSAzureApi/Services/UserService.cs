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

    void UpdateUser(string username, UpdateUser updateUser);

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

    public void UpdateUser(string username, UpdateUser updateUser)
    {
        var user = GetUser(username);

        // Validate
        if (updateUser.Email != user.Email && _context.Users.Any(x => x.Email == updateUser.Email))
            throw new AppException("User with the email '" + user.Email + "' already exists");

        // Hash password if it was entered
        if (!string.IsNullOrEmpty(updateUser.Password))
            user.UserPasswordHash = BCrypt.HashPassword(updateUser.UserPassword);

        // Copy model to user and save
        _mapper.Map(updateUser, user);
        _context.Users.Update(user);
        _context.SaveChanges();
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