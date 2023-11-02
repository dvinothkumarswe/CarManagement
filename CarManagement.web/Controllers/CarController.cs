using CarManagement.web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarManagement.web.Controllers
{
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CarController(ApplicationDbContext dbContext) => _dbContext = dbContext;
        [HttpGet]
        public IActionResult Index()
        {
             
            return View();
        }
    }
}
