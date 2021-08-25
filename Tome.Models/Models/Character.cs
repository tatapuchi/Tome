using System;
using System.Collections.Generic;
using System.Text;

namespace Tome.Models.Models
{
    public class Character : ModelBase
    {
        public string FirstName { get; set; }
        public List<string> MiddleNames { get; set; }
        public string LastName { get; set; }
        public List<string> NickNames { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }

        public string Appearance { get; set; }
        public string Info { get; set; }

        public Universe ParentUniverse { get; set; }
        public List<Book> Books { get; set; }
        public List<Event> Events { get; set; }
    }
}
