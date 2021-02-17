using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EfCoreBug
{
    public static class BugFactory
    {
        public static String GetLongDebugView(bool isItConsole)
        {
            SeedData(isItConsole);

            using var db = new BloggingContext(isItConsole);

            var blog = db.Set<Blog>().First();

            return db.ChangeTracker.DebugView.LongView;
        }

        private static void SeedData(bool isItConsole)
        {
            using var db = new BloggingContext(isItConsole);

            db.Database.Migrate();

            if (db.Set<Blog>().Any())
                return;
            
            var blog = new Blog
            {
                Url = "http://blogs.msdn.com/adonet",
                Post1 = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" },
                Post2 = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" },
                Post3 = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" },
                Post4 = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" },
                Post5 = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" },
                Post6 = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" },
                Post7 = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" },
                Post8 = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" },
                Post9 = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" },
                Post10 = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" },
                Post11 = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" },
                Post12 = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" }
            };

            db.Add(blog);

            db.SaveChanges();
        }
    }
}
