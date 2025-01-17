﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UserManagementApi.Models;

namespace UserManagementApi.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
