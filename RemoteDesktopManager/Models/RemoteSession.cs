using RemoteDesktopManager.Helpers;
using System.ComponentModel;

namespace RemoteDesktopManager.Models
{
    public class RemoteSession : Base.Session
    {
        public long? ColorDepthId { get; set; }
        public RemoteDisplayColor ColorDepth { get; set; }
        public long? SizeId { get; set; }
        public RemoteScreenSize Size { get; set; }

        [DefaultValue(false)]
        public bool IsConsole { get; set; } = false;

        public OnlineStatus? Status { get; set; }
    }
}