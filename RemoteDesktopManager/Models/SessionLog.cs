using System;
using System.ComponentModel.DataAnnotations;

namespace RemoteDesktopManager.Models
{
    public class SessionLog : Base.Model
    {
        [Required]
        public string User { get; set; }

        [Required]
        public string LocalIp { get; set; }

        [Required]
        public DateTimeOffset ConnectTime { get; set; } = DateTimeOffset.Now;

        public DateTimeOffset? DisconnectTime { get; set; }
        public long? SessionId { get; set; }
        public Base.Session Session { get; set; }
    }
}