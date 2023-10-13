using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
            {
                new Post {
                    Title = "First post",
                    Body = "Nunc placerat, ipsum convallis varius commodo, est purus semper elit, a imperdiet magna arcu eget arcu. Vivamus et purus euismod, vehicula nisl id, fringilla tellus. Praesent tristique nibh tortor.",
                    Date = DateTime.Now.AddDays(-10)
                    },
                new Post {
                    Title = "Second post",
                    Body = "Nunc placerat, ipsum convallis varius commodo, est purus semper elit, a imperdiet magna arcu eget arcu. Vivamus et purus euismod, vehicula nisl id, fringilla tellus. Praesent tristique nibh tortor.",
                    Date = DateTime.Now.AddDays(-7)
                    },
                new Post {
                    Title = "Third post",
                    Body = "Nunc placerat, ipsum convallis varius commodo, est purus semper elit, a imperdiet magna arcu eget arcu. Vivamus et purus euismod, vehicula nisl id, fringilla tellus. Praesent tristique nibh tortor.",
                    Date = DateTime.Now.AddDays(-4)
                    }
            };
                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}