using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class ProjectContext :DbContext
    {
        public ProjectContext() : base("DB") { }
        public DbSet<Fall> Falls { get; set; }
        public DbSet<ReportFall> Reports { get; set; }

        public DbSet<User> Users { get; set; }


    }
}
