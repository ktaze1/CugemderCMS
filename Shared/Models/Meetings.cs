using System;
using System.Collections.Generic;

namespace CugemderPortal.Shared.Models
{
    public partial class Meetings
    {
        public int Id { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public bool IsApproved { get; set; }
    }
}
