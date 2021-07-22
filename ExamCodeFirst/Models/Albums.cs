using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCodeFirst.Models
{
    public class Albums
    {
        public Albums()
        {
            Albums_Songs = new HashSet<Albums_songs>();
        }

        public int Album_id { get; set; }
        public int Artist_id { get; set; }
        public string Album_title { get; set; }
        public int Album_year { get; set; }
        public string Album_tracks { get; set; }

        public virtual Artists ArtistsNavigation { get; set; }
        public virtual ICollection<Albums_songs> Albums_Songs { get; set; }
    }
}
