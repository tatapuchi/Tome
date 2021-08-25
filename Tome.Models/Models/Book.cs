using System;
using System.Collections.Generic;
using System.Text;

namespace Tome.Models.Models
{
    public class Book : ModelBase 
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Universe ParentUniverse { get; set; }
        public List<Character> Characters { get; set; }
        public List<Event> Events { get; set; }

    }
}
