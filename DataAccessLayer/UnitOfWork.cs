using BusinessLogicLayer;
using BusinessLogicLayer.Repositories;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            Posts = new PostRepository(_context);
            Users = new UserRepository(_context);
        }

        public IPostRepository Posts { get; private set; }
        public IUsersRepository Users { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
