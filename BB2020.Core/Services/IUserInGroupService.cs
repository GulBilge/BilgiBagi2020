using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BB2020.Core.Services
{
    public interface IUserInGroupService
    {
        Task<IEnumerable<UserInGroup>> GetUserInGroups();
        Task<UserInGroup> GetUserInGroupById(int id);
        Task<IEnumerable<UserInGroup>> GetUserInGroupsByGroupId(int id);
        Task<IEnumerable<UserInGroup>> GetUserInGroupsByUserId(int id);
        Task<UserInGroup> CreateUserInGroup(UserInGroup userInGroup);
        Task UpdateUserInGroup(UserInGroup groupToBeUpdated, UserInGroup userInGroup);
        Task DeleteUserInGroup(UserInGroup userInGroup);
    }
}
