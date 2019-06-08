using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDiary.Models
{
    public class Diary
    {
        public int DiaryID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<Entry> Entries { get; set; }
    }
}
