using CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class CodeFirstContext : DbContext
    {
        DbSet<Student> Studets { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=HP;Database=CodeFirst;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(s =>
            {
                s.HasKey(k => k.Id);
                s.Property(k => k.Id).ValueGeneratedOnAdd().HasColumnType("int");
                s.Property(k => k.FirstName).HasColumnType("NVARCHAR(20)").HasColumnName("FirstName");
                s.Property(k => k.LastName).HasColumnName("LastName").HasColumnType("NVARCHAR(20)");
                s.Property(k => k.TeacherName).HasColumnType("NVARCHAR(20)").HasColumnName("Teacher");
                s.Property(k => k.Mark).HasColumnType("int").HasColumnName("Mark");
            });
            modelBuilder.Entity<Teacher>(s =>
            {
                s.HasKey(k => k.Id);
                s.Property(k => k.Id).HasColumnName("Id").HasColumnType("int").ValueGeneratedOnAdd();
                s.Property(k => k.FirstName).HasColumnType("NVARCHAR(20)").HasColumnName("FirstName");
                s.Property(k => k.LastName).HasColumnName("LastName").HasColumnType("NVARCHAR(20)");
                s.Property(k => k.Subject).HasColumnType("NVARCHAR(20)").HasColumnName("Subject");
                s.Property(k => k.Salary).HasColumnType("decimal").HasColumnName("Salary");
            });
            modelBuilder.Entity<User>(s =>
            {
                s.HasKey(k => k.Id);
                s.Property(k => k.Id).ValueGeneratedOnAdd().HasColumnType("int").HasColumnName("Id");
                s.Property(k => k.Username).HasColumnType("NVARCHAR(20)").HasColumnName("Username");
                s.Property(k => k.Password).HasColumnType("NVARCHAR(20)").HasColumnName("Password");
            });
        }

    }
}
