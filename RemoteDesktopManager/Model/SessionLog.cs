using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDesktopManager.Model
{
    class SessionLog : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        int _SessionLogId;
        public int SessionLogId
        {
            get => _SessionLogId;
            set
            {
                if (_SessionLogId != value)
                {
                    _SessionLogId = value;
                    RaisePropertyChanged("SessionLogId");
                }
            }
        }
        string _WindowUserName;
        public string WindowUserName
        {
            get => _WindowUserName;
            set
            {
                if (_WindowUserName != value)
                {
                    _WindowUserName = value;
                    RaisePropertyChanged("WindowUserName");
                }
            }
        }
        string _LocalIp;
        public string LocalIp
        {
            get => _LocalIp;
            set
            {
                if (_LocalIp != value)
                {
                    _LocalIp = value;
                    RaisePropertyChanged("LocalIp");
                }
            }
        }
        DateTime _DisconnectedTime;
        public DateTime DisconnectedTime
        {
            get => _DisconnectedTime;
            set
            {
                if (_DisconnectedTime != value)
                {
                    _DisconnectedTime = value;
                    RaisePropertyChanged("DisconnectedTime");
                }
            }
        }
        string _ConnectTime;
        public string ConnectTime
        {
            get => _ConnectTime;
            set
            {
                if (_ConnectTime != value)
                {
                    _ConnectTime = value;
                    RaisePropertyChanged("ConnectTime");
                }
            }
        }
    
    }
}
