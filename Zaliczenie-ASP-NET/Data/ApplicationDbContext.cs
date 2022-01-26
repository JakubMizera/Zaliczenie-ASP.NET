using Microsoft.EntityFrameworkCore;
using Zaliczenie_ASP_NET.Models;

namespace Zaliczenie_ASP_NET.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Products> Products { get; set; }   
        public DbSet<Login> Login { get; set; }   
    }
}
