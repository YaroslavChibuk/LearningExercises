using DataAccess.Postgress.Configurations;
using DataAccess.Postgress.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Postgress;

public class LearningDbContext(DbContextOptions<LearningDbContext> options) 
    : DbContext(options)
{
    public DbSet<CourseEntity> Courses { get; set; }
    public DbSet<StudentEntity> Students { get; set; }
    public DbSet<AuthorEntity> Authors { get; set; }
    public DbSet<LessonEntity> Lessons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CourseConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new AuthorConfiguration());
        modelBuilder.ApplyConfiguration(new LessonConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
