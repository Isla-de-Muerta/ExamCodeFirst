using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCodeFirst.Models
{
    public class Artists
    {
        public Artists()
        {
            Albums = new HashSet<Albums>();
            Groups = new HashSet<Groups>();
            Persons = new HashSet<Persons>();
        }

        public int Artist_id { get; set; }
        public int Genre_id { get; set; }
        public int Country_id { get; set; }
        public string Artist_site_url { get; set; }

        public virtual Countries CountriesNavigation { get; set; }
        public virtual Genres GenresNavigation { get; set; }

        public virtual ICollection<Albums> Albums { get; set; }
        public virtual ICollection<Groups> Groups { get; set; }
        public virtual ICollection<Persons> Persons { get; set; }
    }
}
