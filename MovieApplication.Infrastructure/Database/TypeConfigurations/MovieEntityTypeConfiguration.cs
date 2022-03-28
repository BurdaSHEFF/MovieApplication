using MovieApplication.Core.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieApplication.Infrastructure.Database.TypeConfigurations;

public class MovieEntityTypeConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.Property(x => x.Title).HasMaxLength(100);
        builder.Property(x => x.Description).HasMaxLength(9999);
        builder.Property(x => x.TrailerPath).HasMaxLength(1000);
        builder.Property(x => x.MoviePath).HasMaxLength(1000);
    }
}