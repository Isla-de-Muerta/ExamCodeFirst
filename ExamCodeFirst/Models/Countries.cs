using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCodeFirst.Models
{
    public class Countries
    {
        public Countries()
        {
            Artists = new HashSet<Artists>();
        }

        public int Country_id { get; set; }
        public string Country_name { get; set; }

        public virtual ICollection<Artists> Artists { get; set; }
    }
}
