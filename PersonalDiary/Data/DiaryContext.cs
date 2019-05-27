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

        public DbSet<Entry> Entries { get; set; }
        public DbSet<Diary> Diaries { get; set; }
    }
}
