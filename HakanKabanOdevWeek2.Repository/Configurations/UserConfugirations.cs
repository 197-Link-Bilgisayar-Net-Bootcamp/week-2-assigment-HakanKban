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
    internal class UserConfugirations : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(25);
            builder.HasData(new User { Id = 1, CountGame = 24, UserName = "Hakan", MembershipDate = DateTime.Now },
                            new User { Id = 2, CountGame = 34, UserName = "Hakan2", MembershipDate = DateTime.Now }
            );              
        }
    }
}
