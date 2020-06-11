using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestAPIinMemorydb.Model;

namespace RestAPIinMemorydb.Data
{
    public class RestAPIinMemorydbContext : DbContext
    {
        public RestAPIinMemorydbContext (DbContextOptions<RestAPIinMemorydbContext> options)
            : base(options)
        {
            
        }

        public DbSet<RestAPIinMemorydb.Model.TransportTab> TransportTab { get; set; }
    }
}
