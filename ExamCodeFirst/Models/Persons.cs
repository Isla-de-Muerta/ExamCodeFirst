using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCodeFirst.Models
{
    public class Persons
    {
        public int Artist_id { get; set; }
        public string Last_name { get; set; }
        public string First_name { get; set; }
        public DateTime Birthday { get; set; }
        public string Sex { get; set; }

        public virtual Artists ArtistsNavigation { get; set; }
    }
}
