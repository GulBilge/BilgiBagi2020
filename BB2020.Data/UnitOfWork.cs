using BB2020.Core;
using BB2020.Core.Repositories;
using BB2020.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BB2020.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BBDbContext _context;
        private ChatRepository _chatRepository;

        public UnitOfWork(BBDbContext context)
        {
            this._context = context;
        }
        public IChatRepository Chats => _chatRepository ??= new ChatRepository(_context);

        public IActivityRepository Activities => throw new NotImplementedException();

        public ICommentRepository Comments => throw new NotImplementedException();

        public IUserInGroupRepository UserInGroups => throw new NotImplementedException();

        public IUserRepository Users => throw new NotImplementedException();

        public IFileRepository Files => throw new NotImplementedException();

        public IGroupRepository Groups => throw new NotImplementedException();

        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
