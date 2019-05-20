using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDiary.Models
{
    public class Entry
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Entry(int id, string text, DateTime date)
        {
            this.Id = id;
            this.Text = text;
            this.Date = date;
        }
    }
}
