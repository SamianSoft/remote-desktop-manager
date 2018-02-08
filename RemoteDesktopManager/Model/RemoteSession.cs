using RemoteDesktopManager.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDesktopManager.Model
{
    public class RemoteSession : BaseSession
    {
        public enum DisplayColor
        {

        }

        public enum ScreenSize
        {

        }

        public enum OnlineStatus
        {
            Connecting,
            Connected,
            Reconnecting,
            Disconnected
        }

        [Required]
        public DisplayColor Color { get; set; }
        [Required]
        public ScreenSize Size { get; set; }
        [DefaultValue(false)]
        public bool IsConsole { get; set; } = false;
        public OnlineStatus Status { get; set; }

    }
}
