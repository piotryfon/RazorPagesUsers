using Microsoft.EntityFrameworkCore;
using RazorPagesUsers.Entities;
using RazorPagesUsers.UserModel;

namespace RazorPagesUsers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
