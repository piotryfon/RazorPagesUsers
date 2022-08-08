﻿using Microsoft.EntityFrameworkCore;
using RazorPagesUsers.UserModel;

namespace RazorPagesUsers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
