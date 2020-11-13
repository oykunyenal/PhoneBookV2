using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PhoneBook.Models
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext(DbContextOptions<PhoneBookContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
