using System;
using System.Collections.Generic;
using System.Text;

namespace Tome.Models.Models
{
    public class Event : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Universe ParentUniverse { get; set; }
        public List<Character> Characters { get; set; }
        public List<Book> Books { get; set; }
    }
}
