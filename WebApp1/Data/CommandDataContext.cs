using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.Data
{
    public class CommandDataContext : DbContext
    {
        public CommandDataContext(DbContextOptions<CommandDataContext> opt ) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
 
    }
}
