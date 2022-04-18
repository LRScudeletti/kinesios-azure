namespace KinesiOSAzureApi.Controllers;

using Models.Users;
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
    public IActionResult CreateUser(CreateUser createUser)
    {
        _userService.CreateUser(createUser);
        return Ok(new { message = "User '" + createUser.Username + "' created successfully." });
    }

    [HttpGet("read")]
    public IActionResult ReadAllUsers()
    {
        var users = _userService.ReadAllUsers();
        return Ok(users);
    }

    [HttpGet(("read/{username}"))]
    public IActionResult ReadUserByUsername(string username)
    {
        var user = _userService.ReadUserByUsername(username);
        return Ok(user);
    }

    [HttpDelete(("delete/{username}"))]
    public IActionResult DeleteUser(string username)
    {
        _userService.DeleteUser(username);
        return Ok(new { message = "User '" + username + "' deleted successfully." });
    }
}