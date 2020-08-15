using System;

namespace BB2020.Core
{
    public class UserInGroup
    {

        public int Id { get; set; }

        public int GroupId { get; set; }

        public int UserId { get; set; }

        public DateTime InsertDate { get; set; }

        public bool Active { get; set; }

        public bool Favorite { get; set; }

    }
}
