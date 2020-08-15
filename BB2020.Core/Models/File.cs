using System;

namespace BB2020.Core
{
    public class File
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Path { get; set; }

        public DateTime InsertDate { get; set; }

        public int UserId { get; set; }

        public int GroupId { get; set; }

    }
}

