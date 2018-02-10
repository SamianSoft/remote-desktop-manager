using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDesktopManager.Model
{
    public class Session : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        int _SessionId;
        public int SessionId
        {
            get => _SessionId;
            set
            {
                if (_SessionId != value)
                {
                    _SessionId = value;
                    RaisePropertyChanged("SessionId");
                }
            }
        }
        string _Ip;
        public string Ip
        {
            get => _Ip;
            set
            {
                if (_Ip != value)
                {
                    _Ip = value;
                    RaisePropertyChanged("Ip");
                }
            }
        }
        string _Port;
        public string Port
        {
            get => _Port;
            set
            {
                if (_Port != value)
                {
                    _Port = value;
                    RaisePropertyChanged("Port");
                }
            }
        }
        string _UserName;
        public string UserName
        {
            get => _UserName;
            set
            {
                if (_UserName != value)
                {
                    _UserName = value;
                    RaisePropertyChanged("UserName");
                }
            }
        }
        string _Pass;
        public string Pass
        {
            get => _Pass;
            set
            {
                if (_Pass != value)
                {
                    _Pass = value;
                    RaisePropertyChanged("Pass");
                }
            }
        }
        int _SessionType;
        public int SessionType
        {
            get => _SessionType;
            set
            {
                if (_SessionType != value)
                {
                    _SessionType = value;
                    RaisePropertyChanged("SessionType");
                }
            }
        }
        int _OrgUnitId;
        public int OrgUnitId
        {
            get => _OrgUnitId;
            set
            {
                if (_OrgUnitId != value)
                {
                    _OrgUnitId = value;
                    RaisePropertyChanged("OrgUnitId");
                }
            }
        }
        bool _IsActive;
        public bool IsActive
        {
            get => _IsActive;

            set
            {
                if (_IsActive != value)
                {
                    _IsActive = value;
                    RaisePropertyChanged("IsActive");
                }
            }
        }

    }
}
