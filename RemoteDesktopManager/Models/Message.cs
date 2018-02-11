using System.ComponentModel.DataAnnotations;

namespace RemoteDesktopManager.Models
{
    public class Message : Base.Model
    {
        [Required]
        public string FromUser { get; set; }

        [Required]
        public string ToUser { get; set; }

        [Required]
        public bool IsRead { get; set; }
    }
}