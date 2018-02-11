using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RemoteDesktopManager.Models
{
    public class Client : Base.Model
    {
        [Required, MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Phone { get; set; }

        [MaxLength(1000)]
        public string Address { get; set; }

        public byte?[] Logo { get; set; }

        [MaxLength(1000)]
        public string CrmLink { get; set; }

        public long? ParentId { get; set; }
        public Client Parent { get; set; }
        public ICollection<Client> Childs { get; set; } = new HashSet<Client>();
        public ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();
    }
}