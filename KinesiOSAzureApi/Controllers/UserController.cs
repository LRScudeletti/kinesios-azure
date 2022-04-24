using KinesiOSAzureApi.Models;

namespace KinesiOSAzureApi.Controllers;

using Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("create")]
    public IActionResult CreateUser(UserModel userModel)
    {
        _userService.CreateUser(userModel);
        return Ok(new { message = "User '" + userModel.Email + "' created successfully." });
    }

    [HttpGet("read")]
    public IActionResult ReadAllUsers()
    {
        var users = _userService.ReadAllUsers();
        return Ok(users);
    }

    [HttpGet(("read/{username}"))]
    public IActionResult ReadUserByUsername(string email)
    {
        var user = _userService.ReadUserByEmail(email);
        return Ok(user);
    }

    //[HttpPut("update/{username}")]
    //public IActionResult UpdateUser(string username, UpdateUser updateUser)
    //{
    //    _userService.UpdateUser(username, updateUser);
    //    return Ok(new { message = "User '" + username + "' updated successfully." });
    //}

    [HttpDelete(("delete/{username}"))]
    public IActionResult DeleteUser(string username)
    {
        _userService.DeleteUser(username);
        return Ok(new { message = "User '" + username + "' deleted successfully." });
    }
}