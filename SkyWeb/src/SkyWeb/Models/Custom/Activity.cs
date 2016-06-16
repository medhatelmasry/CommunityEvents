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
        public String Notes1 { get; set; }
        public String Notes2 { get; set; }
        public bool IsNotes1Title { get; set; }
        public bool IsNotes2Title { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
