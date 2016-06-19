using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel.Models.API
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        //public string Username { get; set; }
        public String Notes1 { get; set; }
        public String Notes2 { get; set; }
        [Display(Name = "Title1")]
        public bool IsNotes1Title { get; set; }
        [Display(Name = "Title2")]
        public bool IsNotes2Title { get; set; }
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }

        public Activity(DataModel.Models.Activity activity)
        {
            this.ActivityId = activity.ActivityId;
            this.Start = activity.Start;
            this.End = activity.End;
            //this.Username = activity.Username;
            this.Notes1 = activity.Notes1;
            this.Notes2 = activity.Notes2;
            this.IsNotes1Title = activity.IsNotes1Title;
            this.IsNotes2Title = activity.IsNotes2Title;
            this.CategoryId = activity.CategoryId;
            this.CategoryName = activity.Category.Name;
        }
    }
}
