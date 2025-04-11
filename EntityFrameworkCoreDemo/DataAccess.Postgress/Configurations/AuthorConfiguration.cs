using DataAccess.Postgress.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Postgress.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<AuthorEntity>
{
    public void Configure(EntityTypeBuilder<AuthorEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Course)
            .WithOne(x => x.Author)
            .HasForeignKey<AuthorEntity>(x => x.CourceId);
    }
}
