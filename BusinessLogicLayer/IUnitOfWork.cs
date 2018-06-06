using BusinessLogicLayer.Repositories;
using System;

namespace BusinessLogicLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IUsersRepository Users { get; }
        IPostRepository Posts { get; }
        int Complete();
    }
}
