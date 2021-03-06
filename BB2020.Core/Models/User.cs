﻿using System;

namespace BB2020.Core
{
    public class User
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TcNo { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool Active { get; set; }

        public string PhotoPath { get; set; }

    }
}
