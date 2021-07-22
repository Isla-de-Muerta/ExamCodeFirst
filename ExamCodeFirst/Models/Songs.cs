using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCodeFirst.Models
{
    public class Songs
    {
        public Songs()
        {
            Albums_Songs = new HashSet<Albums_songs>();
        }

        public int Song_id { get; set; }
        public string Song_title { get; set; }
        public int Song_duration { get; set; }

        public virtual ICollection<Albums_songs> Albums_Songs { get; set; }
    }
}
