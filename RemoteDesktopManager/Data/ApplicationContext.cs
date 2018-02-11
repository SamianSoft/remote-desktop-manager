
using System.Data.Entity;
using RemoteDesktopManager.Models;

namespace RemoteDesktopManager.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<RemoteSession> RemoteSessions { get; set; }
        public DbSet<SqlSession> SqlSessions { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<RemoteDisplayColor> RemoteDisplayColors { get; set; }
        public DbSet<RemoteScreenSize> ScreenSizes { get; set; }
        public DbSet<SessionLog> SessionLogs { get; set; }
        public ApplicationContext()
        : base("ApplicationDataBase")
        {

        }

    }
}
