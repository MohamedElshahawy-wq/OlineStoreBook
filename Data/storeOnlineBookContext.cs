using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using storeOnlineBook.Models;

namespace storeOnlineBook.Data
{
    public class storeOnlineBookContext : DbContext
    {
        public storeOnlineBookContext (DbContextOptions<storeOnlineBookContext> options)
            : base(options)
        {
        }

        public DbSet<storeOnlineBook.Models.book> book { get; set; }

        public DbSet<storeOnlineBook.Models.usersaccounts> usersaccounts { get; set; }

        public DbSet<storeOnlineBook.Models.orders> orders { get; set; }
        public DbSet<storeOnlineBook.Models.report> report { get; set; }

    }
}
