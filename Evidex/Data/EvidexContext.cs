using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Evidex.Models;

namespace Evidex.Data
{
    public class EvidexContext : DbContext
    {
        public EvidexContext (DbContextOptions<EvidexContext> options)
            : base(options) { }

        public DbSet<UserModel>? UserModel { get; set; }
    }
}
