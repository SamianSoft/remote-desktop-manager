using System.Data.Entity;
using RemoteDesktopManager.Migrations;
using RemoteDesktopManager.Data;

namespace RemoteDesktopManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationContext, Configuration>());
        }
    }
}