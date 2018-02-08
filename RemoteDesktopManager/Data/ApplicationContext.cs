using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteDesktopManager.Model;

namespace RemoteDesktopManager.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<RemoteSession> RemoteSessions { get; set; }
        public DbSet<SqlSession> SqlSessions { get; set; }
        public ApplicationContext()
        : base("ApplicationDataBase")
        {

        }

    }
}
