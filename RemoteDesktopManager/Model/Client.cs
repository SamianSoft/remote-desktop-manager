using System.ComponentModel.DataAnnotations;

namespace RemoteDesktopManager.Model
{
    public class Client : BaseModel
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
        public virtual Client Parent { get; set; }
    }
}