using System.ComponentModel.DataAnnotations;

namespace RemoteDesktopManager.Models
{
    public class Contact : Base.Model
    {
        [Required, MaxLength(250)]
        public string Name { get; set; }

        public string Phone { get; set; }
        public string Mobile { get; set; }
        public int Extention { get; set; }

        [MaxLength(1000)]
        public string CrmLink { get; set; }

        public long? ClientId { get; set; }
        public Client Client { get; set; }
    }
}