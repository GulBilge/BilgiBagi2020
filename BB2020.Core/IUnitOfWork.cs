using BB2020.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BB2020.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IChatRepository Chats { get;}
        IActivityRepository Activities { get; }
        ICommentRepository Comments { get; }
        IUserInGroupRepository UserInGroups { get; }
        IUserRepository Users { get; }
        IFileRepository Files { get; }
        IGroupRepository Groups { get; }
        Task<int> CommitAsync();
    }
}
