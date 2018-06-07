using BusinessLogicLayer.BusinessModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetTopSellingPosts(int count);
        IEnumerable<Post> GetPostsWithUsers(int pageIndex, int pageSize);
    }
}
