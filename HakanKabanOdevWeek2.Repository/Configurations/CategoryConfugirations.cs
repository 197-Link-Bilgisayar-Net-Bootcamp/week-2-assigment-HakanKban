using HakanKabanOdevWeek2.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanKabanOdevWeek2.Repository.Configurations
{
    internal class CategoryConfugirations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(50);
            builder.HasMany<Games>(x => x.Games).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);
            builder.HasData(
                new Category { Id=1, CategoryName ="Sport" },
                new Category { Id=2, CategoryName ="Fight" });

        }
    }
}
