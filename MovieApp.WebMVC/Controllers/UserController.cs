using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace UserApp.WebMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService service)
        {
            _userService = service;
        }

        
    }
}
