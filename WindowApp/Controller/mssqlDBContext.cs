using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowApp.Model;

namespace WindowApp.Controller
{
    class mssqlDBContext : DbContext
    {
        public mssqlDBContext() : base("messengerDBEntities")
        {

        }

        public mssqlDBContext(string connectionString) : base(connectionString)
        {

        }

        public DbSet<tb_logininfo> logininfo { get; set; }
    }
}
