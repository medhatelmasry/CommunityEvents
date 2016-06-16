using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Title1")]
        public bool IsNotes1Title { get; set; }
        [Display(Name = "Title2")]
        public bool IsNotes2Title { get; set; }

        [Display(Name="Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
