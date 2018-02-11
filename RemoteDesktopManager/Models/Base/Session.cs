using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RemoteDesktopManager.Models.Base
{
    public abstract class Session : Model
    {
        [Required, MaxLength(250)]
        public string Ip { get; set; }

        [Required, MaxLength(5)]
        public string Port { get; set; }

        [Required, MaxLength(250)]
        public string LastActiveUser { get; set; }

        [Required, MaxLength(1000)]
        public string Password { get; set; }

        public long ClientId { get; set; }
        public Client Client { get; set; }
        public virtual ICollection<SessionLog> Logs { get; set; } = new HashSet<SessionLog>();
    }
}