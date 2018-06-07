using BusinessLogicLayer.BusinessModels;
using BusinessLogicLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(DataContext context) : base(context)
        {
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }

        public IEnumerable<Post> GetPostsWithUsers(int pageIndex, int pageSize)
        {
            return DataContext.Posts.Include(c => c.User)
            .OrderBy(c => c.Name)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToList();
        }

        public IEnumerable<Post> GetTopSellingPosts(int count)
        {
            return DataContext.Posts.OrderByDescending(c => c.Level).Take(count).ToList();
        }
    }
}
