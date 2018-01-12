using System;
using System.Collections.Generic;

namespace BlueChipTSA.Models
{
    public partial class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IpAddress { get; set; }
        public int? CountryId { get; set; }

        public Countries Country { get; set; }
    }
}
