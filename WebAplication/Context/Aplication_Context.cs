using Microsoft.EntityFrameworkCore;
using WebAplication.Models;

namespace WebAplication.Context
{
    public class Aplication_Context : DbContext
    {
        public Aplication_Context(DbContextOptions<Aplication_Context> options)
            : base(options) { }

        public DbSet<Student> students { get; set; }

        public DbSet<Teacher> teachers { get; set; }

        public DbSet<University> universities { get; set; }

        public DbSet<Subject> subjects { get; set; }

    }
}
