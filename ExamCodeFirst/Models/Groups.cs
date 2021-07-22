using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCodeFirst.Models
{
    public class Groups
    {
        public int Artist_id { get; set; }
        public string Group_name { get; set; }

        public virtual Artists ArtistsNavigation { get; set; }
    }
}
