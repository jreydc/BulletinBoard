using BulletinBoard.Models;
using Microsoft.EntityFrameworkCore;

namespace BulletinBoard.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
