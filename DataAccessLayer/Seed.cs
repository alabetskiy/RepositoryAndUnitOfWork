using BusinessLogicLayer.BusinessModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DataAccessLayer
{
    public class Seed
    {
        private readonly DataContext _context;
        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            // Seeding Data to db
            // Add Tags
            var tags = new Dictionary<string, Tag>
            {
                {"c#", new Tag {Name = "c#"}},
                {"angularjs", new Tag {Name = "angularjs"}},
                {"javascript", new Tag {Name = "javascript"}},
                {"nodejs", new Tag {Name = "nodejs"}},
                {"oop", new Tag {Name = "oop"}},
                {"linq", new Tag {Name = "linq"}},
            };

            foreach (var tag in tags.Values)
                _context.Tags.Add(tag);

            _context.SaveChanges();

            // Add Users

            var users = new List<User>
            {
                new User
                {
                    Name = "Artem Labetskiy"
                },
                new User
                {
                    Name = "Johnnie Trombetta"
                },
                new User
                {
                    Name = "Clair Wenz"
                },
                new User
                {
                    Name = "Vladimir Hilgefort"
                },
                new User
                {
                    Name = "Bob Greenway"
                }
            };

            foreach (var user in users)
                _context.Users.Add(user);

            _context.SaveChanges();

            // Adding post with multiple tags. Many-to-Many Relationship. 

            var post1 = new Post();
            post1.Name = "All about OOP";
            post1.UserId = 21;
            post1.Description = "Digging inside OOP";
            post1.Level = 2;

            var tag1 = new Tag();
            tag1.Name = "Test-Tag-OOP1";

            var tag2 = new Tag();
            tag2.Name = "Test-Tag-OOP2";

            var junktion1 = new PostTag();
            var junktion2 = new PostTag();

            junktion1.Post = post1;
            junktion1.Tag = tag1;

            junktion2.Post = post1;
            junktion2.Tag = tag2;

            post1.Tags.Add(junktion1);
            post1.Tags.Add(junktion2);

            _context.Posts.Add(post1);
            _context.Tags.Add(tag1);
            _context.Tags.Add(tag1);

            _context.SaveChanges();


            //var post2 = new Post();
            //post2.Name = "Explaining SignalR";
            //post2.UserId = 1;
            //post2.Description = "Digging inside SignalR";
            //post2.Level = 2;


            //var post3 = new Post();
            //post3.Name = "The power of JavaScipt";
            //post3.UserId = 2;
            //post3.Description = "Exploring JavaScipt";
            //post3.Level = 1;

            //var tag1 = new Tag();
            //tag1.Name = "c#";

            //var tag2 = new Tag();
            //tag1.Name = "javascript";


            //var junktion1 = new PostTag();
            //var junktion2 = new PostTag();

            //junktion1.Post = post1;
            //junktion1.Tag = tag1;

            //junktion2.Post = post2;
            //junktion2.Tag = tag1;

            //tag1.Posts.Add(junktion1);
            //tag1.Posts.Add(junktion2);

            //_context.Tags.Add(tag1);

            //_context.Posts.Add(post1);
            //_context.Posts.Add(post2);

            //_context.SaveChanges();
            #region Posts
            //var posts = new List<Post>
            //{
            //    new Post
            //    {
            //        Id = 1,
            //        Name = "C# Basics",
            //        UserId = 1,
            //        Description = "Description for C# Basics",
            //        Level = 1,
            //        Tags = new Collection<Tag>()
            //        {
            //            tags["c#"]
            //        }
            //    },
            //    new Post
            //    {
            //        Id = 2,
            //        Name = "C# Intermediate",
            //        UserId = 1,
            //        Description = "Description for C# Intermediate",
            //        Level = 2,
            //        Tags = new Collection<Tag>()
            //        {
            //            tags["c#"],
            //            tags["oop"]
            //        }
            //    },
            //    new Post
            //    {
            //        Id = 3,
            //        Name = "C# Advanced",
            //        UserId = 1,
            //        Description = "Description for C# Advanced",
            //        Level = 3,
            //        Tags = new Collection<Tag>()
            //        {
            //            tags["c#"]
            //        }
            //    },
            //    new Post
            //    {
            //        Id = 4,
            //        Name = "Javascript: Understanding the Weird Parts",
            //        UserId = 2,
            //        Description = "Description for Javascript",
            //        Level = 2,
            //        Tags = new Collection<Tag>()
            //        {
            //            tags["javascript"]
            //        }
            //    },
            //    new Post
            //    {
            //        Id = 5,
            //        Name = "Learn and Understand Angular 73",
            //        UserId = 2,
            //        Description = "Description for Angular 73",
            //        Level = 2,
            //        Tags = new Collection<Tag>()
            //        {
            //            tags["angularjs"]
            //        }
            //    },
            //    new Post
            //    {
            //        Id = 6,
            //        Name = "Learn and Understand NodeJS",
            //        UserId = 2,
            //        Description = "Description for NodeJS",
            //        Level = 2,
            //        Tags = new Collection<Tag>()
            //        {
            //            tags["nodejs"]
            //        }
            //    },
            //    new Post
            //    {
            //        Id = 7,
            //        Name = "Programming for Complete Beginners",
            //        UserId = 3,
            //        Description = "Description for Programming for Beginners",
            //        Level = 1,
            //        Tags = new Collection<Tag>()
            //        {
            //            tags["c#"]
            //        }
            //    },
            //    new Post
            //    {
            //        Id = 8,
            //        Name = "Power of JavaScript. Callback.",
            //        UserId = 4,
            //        Description = "All about callbacks in JavaScipt",
            //        Level = 1,
            //        Tags = new Collection<Tag>()
            //        {
            //            tags["c#"]
            //        }
            //    },
            //    new Post
            //    {
            //        Id = 9,
            //        Name = "Learn MS SQL Server",
            //        UserId = 4,
            //        Description = "Be the best SQL Server Administrator",
            //        Level = 1,
            //        Tags = new Collection<Tag>()
            //        {
            //            tags["javascript"]
            //        }
            //    }
            //};
            #endregion

        }
    }
}
