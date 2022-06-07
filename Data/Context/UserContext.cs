using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class UserContext: DbContext
    {

        public UserContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
