﻿using System;
using System.Collections.Generic;

namespace CugemderPortal.Shared.Models
{
    public partial class JobTitles
    {
        public JobTitles()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
        }

        public int Id { get; set; }
        public string JobTitle { get; set; }

        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
