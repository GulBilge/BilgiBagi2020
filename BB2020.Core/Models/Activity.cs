using System;

namespace BB2020.Core
{
    public class Activity
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime ActivityDate { get; set; }

        public string Time { get; set; }

        public string Place { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int UserId { get; set; }

        public int GroupId { get; set; }

    }
}
