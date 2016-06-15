using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyWeb.Models.Custom
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Username { get; set; }
        public DateTime Created { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
