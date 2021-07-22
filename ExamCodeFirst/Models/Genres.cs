using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCodeFirst.Models
{
    public class Genres
    {
        public Genres()
        {
            Artists = new HashSet<Artists>();
        }

        public int Genre_id { get; set; }
        public string Genre_name { get; set; }

        public virtual ICollection<Artists> Artists { get; set; }
    }
}
