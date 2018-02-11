using System.ComponentModel.DataAnnotations;

namespace RemoteDesktopManager.Models
{
    public class Contact : Base.Model
    {
        string _name;
        string _phone;
        string _mobile;
        int _extention;
        string _crmLink;
        long? _clientId;
        Client _client;

        [Required, MaxLength(250)]
        public string Name
        {
            get => _name;
            set { _name = value; RaisePropertyChanged(); }
        }

        public string Phone
        {
            get => _phone;
            set { _phone = value; RaisePropertyChanged(); }
        }

        public string Mobile
        {
            get => _mobile;
            set { _mobile = value; RaisePropertyChanged(); }
        }

        public int Extention
        {
            get => _extention;
            set { _extention = value; RaisePropertyChanged(); }
        }

        [MaxLength(1000)]
        public string CrmLink
        {
            get => _crmLink;
            set { _crmLink = value; RaisePropertyChanged(); }
        }

        public long? ClientId
        {
            get => _clientId;
            set { _clientId = value; RaisePropertyChanged(); }
        }

        public Client Client
        {
            get => _client;
            set { _client = value; RaisePropertyChanged(); }
        }
    }
}