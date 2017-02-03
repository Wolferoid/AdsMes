using Kraft.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraft.DAL.EF
{
    public class KraftContext : DbContext
    {
        public DbSet<Checklist> Checklists { get; set; }
        public DbSet<DrillCard> DrillCards { get; set; }

        public KraftContext(string connectionString) : base(connectionString)
        {
        }
    }
}
