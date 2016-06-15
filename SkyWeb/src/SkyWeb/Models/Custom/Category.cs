using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyWeb.Models.Custom
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Created { get; set; }

        public List<Activity> Activities { get; set; }
    }
}
