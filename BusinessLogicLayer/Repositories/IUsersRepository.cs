using BusinessLogicLayer.BusinessModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Repositories
{
    public interface IUsersRepository : IRepository<User>
    {
        User GetAuthorWithPosts(int id);
    }
}
