using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyWeb.Models.Custom
{
    public class SeedData
    {
        public static void Initialize(SkyContext db)
        {
            if (!db.Categories.Any()) {
                db.Categories.AddRange(getCategoryData());
                db.SaveChanges();

                db.Activities.AddRange(getActivityData(db));
                db.SaveChanges();

            }
        }

        public static List<Category> getCategoryData()
        {
            List<Category> items = new List<Category>() {
                new Category { Name = "Liturgy",Created = DateTime.Now},
                new Category { Name = "Picnic",Created = DateTime.Now},
                new Category { Name = "Dinner",Created = DateTime.Now},
            };

            return items;
        }

        public static List<Activity> getActivityData(SkyContext db)
        {
            List<Activity> items = new List<Activity>() {
                new Activity {
                    CategoryId = db.Categories.FirstOrDefault(c => c.Name == "Liturgy").CategoryId,
                    Start = Convert.ToDateTime("2015/09/09 16:00:00"),
                    End = Convert.ToDateTime("2015/09/09 18:00:00"),
                    Created = DateTime.Now
                },
                new Activity {
                    CategoryId = db.Categories.FirstOrDefault(c => c.Name == "Picnic").CategoryId,
                    Start = Convert.ToDateTime("2016/06/09 10:00:00"),
                    End = Convert.ToDateTime("2016/06/09 13:30:00"),
                    Created = DateTime.Now
                },
                new Activity {
                    CategoryId = db.Categories.FirstOrDefault(c => c.Name == "Picnic").CategoryId,
                    Start = Convert.ToDateTime("2016/02/12 13:00:00"),
                    End = Convert.ToDateTime("2016/02/12 20:30:00"),
                    Created = DateTime.Now
                },
                new Activity {
                    CategoryId = db.Categories.FirstOrDefault(c => c.Name == "Dinner").CategoryId,
                    Start = Convert.ToDateTime("2016/04/22 18:00:00"),
                    End = Convert.ToDateTime("2016/04/22 20:30:00"),
                    Created = DateTime.Now
                },
            };

            return items;
        }

    }
}
