using System;

namespace BB2020.Core
{
    public class Chat
    {

        public int Id { get; set; }

        public string Message { get; set; }

        public DateTime InsertDate { get; set; }

        public int UserId { get; set; }

        public int GroupId { get; set; }

    }
}
