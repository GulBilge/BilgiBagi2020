using System;

namespace BB2020.Core
{
    public class Comment
    {

        public int Id { get; set; }

        public string Message { get; set; }

        public int FileId { get; set; }

        public int UserId { get; set; }

        public DateTime InsertDate { get; set; }

    }

}

