using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.EFCore
{
    public class OnlineTestContext : DbContext
    {
        public OnlineTestContext(DbContextOptions<OnlineTestContext> options) : base(options)
        {
        }

        public DbSet<Language> Languages { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers{ get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<QuestionType> QuestionType { get; set; }
        public DbSet<Result> Result { get; set; }
    }
}
