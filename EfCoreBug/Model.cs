using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Xamarin.Essentials;

namespace EfCoreBug
{
    public class BloggingContext : DbContext
    {
        private const string _dbName = "blogging.db";

        private readonly bool _isItConsole;

        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Post>? Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(
                _isItConsole ? 
                    $"Data Source={_dbName}" : 
                    $"Data Source={Path.Combine(FileSystem.AppDataDirectory, _dbName)}");
        }

        public BloggingContext(bool isItConsole)
        {
            _isItConsole = isItConsole;

            SQLitePCL.Batteries_V2.Init();
        }
    }

    public class Blog
    {
        public Guid Id { get; set; }
        public string? Url { get; set; }

        public Post? Post1 { get; set; }
        public Post? Post2 { get; set; }
        public Post? Post3 { get; set; }
        public Post? Post4 { get; set; }
        public Post? Post5 { get; set; }
        public Post? Post6 { get; set; }
        public Post? Post7 { get; set; }
        public Post? Post8 { get; set; }
        public Post? Post9 { get; set; }
        public Post? Post10 { get; set; }
        public Post? Post11 { get; set; }
        public Post? Post12 { get; set; }
    }

    public class Post
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
}
