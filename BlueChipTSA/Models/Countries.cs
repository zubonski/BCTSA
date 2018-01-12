using System;
using System.Collections.Generic;

namespace BlueChipTSA.Models
{
    public partial class Countries
    {
        public Countries()
        {
            People = new HashSet<People>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<People> People { get; set; }
    }
}
