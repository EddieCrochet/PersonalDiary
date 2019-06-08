using Microsoft.EntityFrameworkCore;
using PersonalDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDiary.Data
{
    public class DiaryContext : DbContext
    {
        public DiaryContext(DbContextOptions<DiaryContext> options) : base (options)
            {
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diary>().HasKey(x => x.DiaryID).ForSqlServerIsClustered();
            modelBuilder.Entity<Diary>().Property(x => x.DiaryID).UseSqlServerIdentityColumn();
        }

        public DbSet<Entry> Entries { get; set; }
        public DbSet<Diary> Diaries { get; set; }
    }
}
