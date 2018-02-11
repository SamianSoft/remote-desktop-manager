using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RemoteDesktopManager.Models.Base
{
    public abstract class Session : Model
    {
        string _ip;
        string _port;
        string _lastActiveUser;
        string _password;
        long _clientId;
        Client _client;
        ICollection<SessionLog> _logs = new HashSet<SessionLog>();

        [Required, MaxLength(250)]
        public string Ip
        {
            get => _ip;
            set
            {
                _ip = value;
                RaisePropertyChanged();
            }
        }

        [Required, MaxLength(5)]
        public string Port
        {
            get => _port;
            set
            {
                _port = value;
                RaisePropertyChanged();
            }
        }

        [Required, MaxLength(250)]
        public string LastActiveUser
        {
            get => _lastActiveUser;
            set
            {
                _lastActiveUser = value;
                RaisePropertyChanged();
            }
        }

        [Required, MaxLength(1000)]
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }

        public long ClientId
        {
            get => _clientId;
            set
            {
                _clientId = value;
                RaisePropertyChanged();
            }
        }

        public Client Client
        {
            get => _client;
            set
            {
                _client = value;
                RaisePropertyChanged();
            }
        }

        public ICollection<SessionLog> Logs
        {
            get => _logs;
            set
            {
                _logs = value;
                RaisePropertyChanged();
            }
        }
    }
}