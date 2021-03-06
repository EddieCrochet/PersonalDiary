﻿using PersonalDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDiary.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DiaryContext context)
        {
            context.Database.EnsureCreated();

            if (context.Entries.Any() && context.Diaries.Any())
            {
                return; //db has been seeded or has data
            }

            var entries = new Entry[]
            {
                new Entry{Date=DateTime.Parse("05/16/2019 05:55PM"),
                    Text ="Wowzers, it's my bday",
                    DiaryID = 1}
            };

            foreach(Entry e in entries)
            {
                context.Entries.Add(e);
            }


            var diaries = new Diary[]
            {
                new Diary{Title="MY FIRST EDIARY",
                    CreatedDate =DateTime.Parse("05/16/2019 05:55PM")
                     }
            };

            foreach (Diary e in diaries)
            {
                context.Diaries.Add(e);
            }

            context.SaveChanges();
        }
    }
}
