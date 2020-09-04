using System;
using System.Collections.Generic;

namespace CugemderPortal.Shared.Models
{
    public partial class Positions
    {
        public Positions()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
        }

        public int Id { get; set; }
        public string Position { get; set; }

        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
