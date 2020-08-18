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
        private ActivityRepository _activityRepository;
        private CommentRepository _commentRepository;
        private UserInGroupRepository _userInGroupRepository;
        private UserRepository _userRepository;
        private FileRepository _fileRepository;
        private GroupRepository _groupRepository;

        public UnitOfWork(BBDbContext context)
        {
            this._context = context;
        }
        public IChatRepository Chats => _chatRepository ??= new ChatRepository(_context);

        public IActivityRepository Activities => _activityRepository??= new ActivityRepository(_context);

        public ICommentRepository Comments => _commentRepository ??= new CommentRepository(_context);

        public IUserInGroupRepository UserInGroups => _userInGroupRepository ??= new UserInGroupRepository(_context);

        public IUserRepository Users => _userRepository ??= new UserRepository(_context);

        public IFileRepository Files => _fileRepository ??= new FileRepository(_context);

        public IGroupRepository Groups => _groupRepository ??= new GroupRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
