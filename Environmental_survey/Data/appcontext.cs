using Environmental_survey.Models;

using Microsoft.EntityFrameworkCore;

namespace Environmental_survey.Data
{
    public class appcontext : DbContext
    {
        public appcontext(DbContextOptions<appcontext> options) : base(options)
        {

        }

        public DbSet<contact> contacts { get; set; }
        public DbSet<register> registers { get; set; }
        public DbSet<Survey> surveys { get; set; }
        public DbSet<faculty> faculties { get; set; }
        public DbSet<Student> students { get; set; }

        public DbSet<FaQs> faQs { get; set; }

        public DbSet<user> stdparticipate { get; set; }
        public DbSet<competition> competitions { get; set; }
        public DbSet<Environmental_survey.Models.competition_>? competition_ { get; set; }
    }
}
