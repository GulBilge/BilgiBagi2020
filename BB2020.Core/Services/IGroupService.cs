using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BB2020.Core.Services
{
  public  interface IGroupService
    {
        Task<IEnumerable<Group>> GetGroups();
        Task<Group> GetGroupById(int id);
        Task<Group> Create(Group group);
        Task UpdateGroup(Group groupToBeUpdated, Group group);
        Task DeleteGroup(Group group);

    }
}
