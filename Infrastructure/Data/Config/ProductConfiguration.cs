using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Example>
    {
        public void Configure(EntityTypeBuilder<Example> builder)
        {
           builder.Property(x => x.Id).IsRequired();
           builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
           builder.Property(x => x.Description).IsRequired();
           builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
           builder.Property(x => x.PictureUrl).IsRequired();
           builder.HasOne(b => b.ExampleItem).WithMany().HasForeignKey(p => p.ExampleItemId);
        }
    }
}