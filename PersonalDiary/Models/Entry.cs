using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDiary.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
