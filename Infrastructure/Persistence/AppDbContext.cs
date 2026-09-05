using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using MongoDB.EntityFrameworkCore.Storage.ValueConversion;
using MongoDB.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence
{
    public class AppDbContext: DbContext
    {
        public DbSet<Config> Configs { get; set;  }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<History> Histories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToCollection("users");
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Id)
                    .HasConversion<StringToObjectIdConverter>()
                    .HasValueGenerator<StringObjectIdValueGenerator>()
                    .ValueGeneratedOnAdd();
                entity.Property(u => u.Name).HasElementName("name");
                entity.Property(u => u.Email).HasElementName("email");
                entity.Property(u => u.Password).HasElementName("password");
                entity.Property(u => u.TotalScore).HasElementName("totalScore");
                entity.Property(u => u.Configs).HasElementName("configs");
            });

            modelBuilder.Entity<Config>(entity => {
                entity.ToCollection("configs");
                entity.HasKey(u => u.Id);
                entity.Property(c => c.Id)
                    .HasConversion<StringToObjectIdConverter>()
                    .HasValueGenerator<StringObjectIdValueGenerator>()
                    .ValueGeneratedOnAdd();
                entity.Property(c => c.Name).HasElementName("name");
                entity.Property(c => c.Timer).HasElementName("timer");
                entity.Property(c => c.Seconds).HasElementName("seconds");
                entity.Property(c => c.NumberQuestions).HasElementName("numberQuestions");
                entity.Property(c => c.MultipleChoice).HasElementName("multipleChoice");
                entity.Property(c => c.Random).HasElementName("random");
                entity.Property(c => c.Category).HasElementName("category");
            });

          

            modelBuilder.Entity<History>(entity => {
                entity.ToCollection("histories");
                entity.HasKey(u => u.Id);
                entity.Property(h => h.Id)
                    .HasConversion<StringToObjectIdConverter>()
                    .HasValueGenerator<StringObjectIdValueGenerator>()
                    .ValueGeneratedOnAdd();
                entity.Property(h => h.Username).HasElementName("user");
                entity.HasIndex(u => u.Username);
                entity.Property(h => h.Score).HasElementName("score");
                entity.Property(h => h.QuestionsTotal).HasElementName("questionsTotal");
                entity.Property(h => h.QuestionsCorrect).HasElementName("questionsCorrect");
                entity.Property(h => h.MultipleChoice).HasElementName("multipleChoice");
                entity.Property(h => h.Random).HasElementName("random");
                entity.Property(h => h.Timer).HasElementName("timer");
                entity.Property(h => h.Seconds).HasElementName("seconds");
                entity.Property(h => h.Date).HasElementName("date");
            });


            modelBuilder.Entity<Question>(entity => {
                entity.ToCollection("questions");
                entity.HasKey(q => q.Id);
                entity.Property(q => q.Id)
                    .HasConversion<StringToObjectIdConverter>()
                    .HasValueGenerator<StringObjectIdValueGenerator>()
                    .ValueGeneratedOnAdd();
                entity.Property(q => q.QuestionName).HasElementName("question");
                entity.Property(q => q.Options).HasElementName("options");
                entity.Property(q => q.Answer).HasElementName("answer");
                entity.Property(q => q.Category).HasElementName("category");
                entity.HasIndex(q => q.Category);
            });

        }

    }
}
