using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCodeFirst.Models
{
    public class Albums_songs
    {
        public int Album_id { get; set; }
        public int Song_id { get; set; }
        public int Track_number { get; set; }

        public virtual Albums AlbumsNavigation { get; set; }
        public virtual Songs SongsNavigation { get; set; }
    }
}
