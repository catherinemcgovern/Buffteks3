using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;  //where do I really need to install this.. 

namespace Buffteks3
{
    public class AppDbContext : DbContext
    {
        public const string ConnectionString = @"Data Source=MyFirstEfCoreDb.db";
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            {

            optionsBuilder.UseSqlite(ConnectionString);}
            
            public DbSet<Student> Students {get; set;}
            }

            }
            
