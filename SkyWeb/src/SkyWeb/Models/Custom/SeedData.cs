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
            }

            if (!db.Activities.Any()) {
                db.Activities.AddRange(getActivityData(db));
                db.SaveChanges();
            }
        }

        public static List<Category> getCategoryData()
        {
            List<Category> items = new List<Category>() {
                new Category { Name = "Divine Liturgy",Created = DateTime.Now},
                new Category { Name = "English Divine Liturgy",Created = DateTime.Now},
                new Category { Name = "Arabic Divine Liturgy",Created = DateTime.Now},
                new Category { Name = "Teen Social Night",Created = DateTime.Now},
                new Category { Name = "Prayer Meeting",Created = DateTime.Now},
                new Category { Name = "Versper Prayers",Created = DateTime.Now},
                new Category { Name = "Bible Study",Created = DateTime.Now},
                new Category { Name = "Sunday School",Created = DateTime.Now},
                new Category { Name = "Hymns Class",Created = DateTime.Now},
                new Category { Name = "Raising the morning incense",Created = DateTime.Now},
                new Category { Name = "Prayer Meeting",Created = DateTime.Now},
                new Category { Name = "Weekly youth meeting",Created = DateTime.Now},
                new Category { Name = "Deacon response class",Created = DateTime.Now},
            };

            return items;
        }

        public static List<Activity> getActivityData(SkyContext db)
        {
            List<Activity> items = new List<Activity>() {
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Divine Liturgy"),
                    Start = Convert.ToDateTime("2016/06/14 08:30:00"),
                    End = Convert.ToDateTime("2016/06/14 10:00:00"),
                    Notes1 = "Father Bisenty followed by Senior's Day",
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Divine Liturgy"),
                    Start = Convert.ToDateTime("2016/06/15 08:30:00"),
                    End = Convert.ToDateTime("2016/06/15 10:30:00"),
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Teen Social Night"),
                    Start = Convert.ToDateTime("2016/06/17 19:00:00"),
                    End = Convert.ToDateTime("2016/06/17 22:00:00"),
                    Notes1 = "Ages 13-19",
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Prayer Meeting"),
                    Start = Convert.ToDateTime("2016/06/17 19:00:00"),
                    End = Convert.ToDateTime("2016/06/17 20:00:00"),
                    Notes1 = "At Church (New)",
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Divine Liturgy"),
                    Start = Convert.ToDateTime("2016/06/18 09:00:00"),
                    End = Convert.ToDateTime("2016/06/18 11:00:00"),
                    Notes1 = "Father Armia",
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Versper Prayers"),
                    Start = Convert.ToDateTime("2016/06/18 18:15:00"),
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Bible Study"),
                    Start = Convert.ToDateTime("2016/06/18 18:45:00"),
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Sunday School"),
                    Start = Convert.ToDateTime("2016/06/18 18:45:00"),
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Hymns Class"),
                    Start = Convert.ToDateTime("2016/06/18 18:45:00"),
                    Notes1 = "New - Grades 1-11",
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Raising the morning incense"),
                    Start = Convert.ToDateTime("2016/06/19 08:30:00"),
                    End = Convert.ToDateTime("2016/06/19 09:00:00"),
                    Notes1 = "For the Month of June, English Liturgies will be at Church & Arabic Liturgies will be at the Gym",
                    Notes2 = "Feast of Pentecost",
                    IsNotes1Title = true,
                    IsNotes2Title = true,
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Divine Liturgy"),
                    Start = Convert.ToDateTime("2016/06/19 09:00:00"),
                    End = Convert.ToDateTime("2016/06/19 11:30:00"),
                    Notes1 = "Feast of Pentecost - One Liturgy at Church",
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Weekly youth meeting"),
                    Start = Convert.ToDateTime("2016/06/19 12:00:00"),
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Deacon response class"),
                    Start = Convert.ToDateTime("2016/06/19 12:15:00"),
                    End = Convert.ToDateTime("2016/06/19 13:00:00"),
                    Created = DateTime.Now
                },
                new Activity {
                    Category = db.Categories.FirstOrDefault(c => c.Name == "Bible Study"),
                    Start = Convert.ToDateTime("2016/06/18 13:00:00"),
                    End = Convert.ToDateTime("2016/06/18 13:30:00"),
                    Notes1 = "Sunday School Children ages 8-12",
                    Created = DateTime.Now
                },
            };

            return items;
        }

    }
}
