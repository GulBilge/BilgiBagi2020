using BB2020.Core;
using BB2020.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BB2020.Data.Repositories
{
    public class ChatRepository : Repository<Chat>, IChatRepository
    {
        public ChatRepository(BBDbContext context) : base(context)
        {
        }
    }
}
