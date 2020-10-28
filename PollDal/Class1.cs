using Microsoft.EntityFrameworkCore;
using System;

namespace PollDal
{
    public class QuestionContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;initial catalog=Quiz;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Answer> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

    }
}
