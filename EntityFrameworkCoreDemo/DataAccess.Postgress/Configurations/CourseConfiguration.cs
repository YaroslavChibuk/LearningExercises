using DataAccess.Postgress.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Postgress.Configurations;

public class CourseConfiguration : IEntityTypeConfiguration<CourseEntity>
{    public void Configure(EntityTypeBuilder<CourseEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Author)
            .WithOne(x => x.Course)
            .HasForeignKey<CourseEntity>(x => x.AuthorId);

        builder.HasMany(x => x.Lessons)
            .WithOne(x => x.Course)
            .HasForeignKey(x => x.CourseId);

        builder.HasMany(x => x.Students)
            .WithMany(x => x.Courses);
    }
}
