using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RemoteDesktopManager.Models
{
    public class Client : Base.Model
    {
        string _name;
        string _phone;
        string _address;
        byte?[] _logo;
        string _crmLink;
        long? _parentId;
        Client _parent;
        ICollection<Client> _childs = new HashSet<Client>();
        ICollection<Contact> _contacts = new HashSet<Contact>();

        [Required, MaxLength(250)]
        public string Name
        {
            get => _name;
            set { _name = value; RaisePropertyChanged(); }
        }

        [MaxLength(250)]
        public string Phone
        {
            get => _phone;
            set { _phone = value; RaisePropertyChanged(); }
        }

        [MaxLength(1000)]
        public string Address
        {
            get => _address;
            set { _address = value; RaisePropertyChanged(); }
        }

        public byte?[] Logo
        {
            get => _logo;
            set { _logo = value; RaisePropertyChanged(); }
        }

        [MaxLength(1000)]
        public string CrmLink
        {
            get => _crmLink;
            set { _crmLink = value; RaisePropertyChanged(); }
        }

        public long? ParentId
        {
            get => _parentId;
            set { _parentId = value; RaisePropertyChanged(); }
        }

        public Client Parent
        {
            get => _parent;
            set { _parent = value; RaisePropertyChanged(); }
        }

        public ICollection<Client> Childs
        {
            get => _childs;
            set { _childs = value; RaisePropertyChanged(); }
        }

        public ICollection<Contact> Contacts
        {
            get => _contacts;
            set { _contacts = value; RaisePropertyChanged(); }
        }
    }
}