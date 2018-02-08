using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDesktopManager.Model
{
    public abstract class BaseSession:BaseModel
    {
        [Required,MaxLength(250)]
        public string Ip { get; set; }
        [Required, MaxLength(5)]
        public string Port { get; set; }
        [Required, MaxLength(250)]
        public string User { get; set; }
        [Required, MaxLength(1000)]
        public string Password { get; set; }
        public long ClientId { get; set; }
        public Client Client { get; set; }

    }
}
