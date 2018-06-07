using BusinessLogicLayer.BusinessModels;
using BusinessLogicLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : Repository<User>, IUsersRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }

        public User GetUsersWithPosts(int id)
        {
            return DataContext.Users.Include(a => a.Posts).SingleOrDefault(a => a.Id == id);
        }
    }
}
