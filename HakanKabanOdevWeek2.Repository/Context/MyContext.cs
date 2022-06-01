using HakanKabanOdevWeek2.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HakanKabanOdevWeek2.Repository.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
                
        }
        DbSet<Category> Categories { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Games> Games { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configiration işlemlerini yaptığımız sınıflarımızı tanımladık.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            //Many To Many İlişki GamesUser
            modelBuilder.Entity<UserGames>().HasKey(ug => new
            {
                ug.UserId,
                ug.GamesId
            });
            modelBuilder.Entity<UserGames>().HasOne(ug => ug.User).WithMany(ug => ug.UserGames).HasForeignKey(ug => ug.GamesId);
            modelBuilder.Entity<UserGames>().HasOne(ug => ug.Games).WithMany(ug => ug.UserGames).HasForeignKey(ug => ug.UserId);

        }
    }
}
