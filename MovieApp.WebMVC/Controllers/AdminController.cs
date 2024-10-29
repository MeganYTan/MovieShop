using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace MovieApp.WebMVC.Controllers
{
    public class AdminController: Controller
    {
        private readonly IAdminService _adminService;
        public AdminController(IAdminService service)
        {
            _adminService = service;
        }
    }
}
