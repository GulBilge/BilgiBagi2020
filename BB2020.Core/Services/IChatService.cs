using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BB2020.Core.Services
{
  public  interface IChatService
    {
        Task<IEnumerable<Chat>> GetChats();
        Task<Chat> GetChatById(int id);
        Task<Chat> CreateChat(Chat newChat);
        Task UpdateChat(Chat chatToBeUpdated, Chat chat);
        Task DeleteChat(Chat chat);
    }
}
