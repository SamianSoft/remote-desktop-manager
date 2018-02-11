using System.Data.Entity;
using RemoteDesktopManager.Data;
using System.Linq;

namespace RemoteDesktopManager.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var context = new ApplicationContext();
            var clients = context.Clients.Include(_ => _.Childs).Include(_ => _.Contacts).Include(_ => _.Parent).ToList();
            var sqlSessions = context.SqlSessions.Include(_ => _.Client).ToList();
            var remoteSessions = context.RemoteSessions.Include(_ => _.Client).Include(_=>_.ColorDepth).Include(_=>_.Size).ToList();
        }
    }
}