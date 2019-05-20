using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonalDiary.Models
{
    public class EntryContext : DbContext
    {
        public EntryContext (DbContextOptions<EntryContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalDiary.Models.Entry> Entry { get; set; }
    }
}
