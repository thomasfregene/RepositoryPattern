using Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RespositoryContext : DbContext
    {
        public RespositoryContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
