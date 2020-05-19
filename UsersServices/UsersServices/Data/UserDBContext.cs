﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserServices.Models;


namespace UserServices.Data
{
    public class UserDBContext : DbContext
    {

        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {

        }
        public DbSet<User> UsersInfo { get; set; }
    }

}

