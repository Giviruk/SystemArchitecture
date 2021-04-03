using System;
using SystemArchitecture.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SystemArchiteture.Data
{
    public class AppDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public DbSet<Lesson> Lessons { get; set; }
        
        public DbSet<Competence> Competences { get; set; }
        
        public DbSet<Image> Images { get; set; }

        public AppDbContext(DbContextOptions options): base(options)
        {
        }
    }
}