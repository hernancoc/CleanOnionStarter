using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loggin.Domain.Entities;

namespace Loggin.Infrastructure.Context
{
    public class LogginContext:DbContext
    {
        public LogginContext(DbContextOptions<LogginContext> options) : base(options){ }

        public DbSet<Users>Users { get; set; }
        
    }
}
