using CarManagement.web.Models;
using Microsoft.EntityFrameworkCore;

namespace CarManagement.web.Data
{
    public class ApplicationDbcontext :DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }    
    }
}
