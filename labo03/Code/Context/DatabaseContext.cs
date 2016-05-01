using Objects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Lecturer> lecturers { get; set; }
        public DbSet<OLA> OLAs { get; set; }
        public DbSet<OPO> OPOs { get; set; }
        public DatabaseContext() : base("name=db_labo02")
        {
                this.lecturers.Create();
                this.OLAs.Create();
                this.OPOs.Create();
        }
        
    }
}
