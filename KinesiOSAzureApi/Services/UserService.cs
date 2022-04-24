using KinesiOSAzureApi.Models;

namespace KinesiOSAzureApi.Services;

using AutoMapper;
using BCrypt.Net;
using Entities;
using Helpers;

public interface IUserService
{
    void CreateUser(UserModel userModel);

    IEnumerable<User>? ReadAllUsers();

    User ReadUserByEmail(string email);

    //void UpdateUser(string username, UpdateUser updateUser);

    void DeleteUser(string email);
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

    public void CreateUser(UserModel userModel)
    {
        // Validate
        if (_context.Users != null && _context.Users.Any(x => x.Email == userModel.Email))
            throw new AppException("Email '" + userModel.Email + "' already exists.");

        // Map createUser to new user object
        var user = _mapper.Map<User>(userModel);

        // Hash password
        user.PasswordHash = BCrypt.HashPassword(userModel.Password);

        // Save user
        _context.Users?.Add(user);
        _context.SaveChanges();
    }

    public IEnumerable<User>? ReadAllUsers()
    {
        return _context.Users;
    }

    public User ReadUserByEmail(string email)
    {
        return GetUser(email);
    }

    //public void UpdateUser(string username, UpdateUser updateUser)
    //{
    //    var user = GetUser(username);

    //    // Validate
    //    if (_context.Users != null && updateUser.UserEmail != user.Email &&
    //        _context.Users.Any(x => x.Email == updateUser.UserEmail))
    //        throw new AppException("Email '" + user.Email + "' already exists.");

    //    // Hash password if it was entered
    //    if (!string.IsNullOrEmpty(updateUser.UserPassword))
    //        user.UserPasswordHash = BCrypt.HashPassword(updateUser.UserPassword);

    //    // Copy model to user and save
    //    _mapper.Map(updateUser, user);
    //    _context.Users?.Update(user);
    //    _context.SaveChanges();
    //}

    public void DeleteUser(string email)
    {
        var user = GetUser(email);
        _context.Users?.Remove(user);
        _context.SaveChanges();
    }

    // Helper method
    private User GetUser(string email)
    {
        var user = _context.Users?.Find(email);
        if (user == null)
            throw new KeyNotFoundException("Email '" + email + "' not found.");

        return user;
    }
}