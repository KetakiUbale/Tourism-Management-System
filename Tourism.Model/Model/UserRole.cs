﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tourism.Model
{
    public class UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        List<Package> Packages { get; set; }

    }
}
