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
    internal class GamesConfiguration : IEntityTypeConfiguration<Games>
    {
        public void Configure(EntityTypeBuilder<Games> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.GamesName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.DownloadCounts).IsRequired();
            builder.HasData(
                new Games { Id = 1, GamesName = "Pes2022", DownloadCounts = 3000, CategoryId = 1 },
                new Games { Id = 2, GamesName = "Fifa2022", DownloadCounts = 4000, CategoryId = 1 },
                new Games { Id = 3, GamesName = "Tekken8", DownloadCounts = 3200, CategoryId = 2 }
            );

           // builder.HasOne<Category>(x => x.Category).WithMany(x => x.Games).HasForeignKey(x => x.CategoryId);
        }
    }
}
