using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDesktopManager.Model
{
    class RemoteSession : Session, INotifyPropertyChanged
    {
       
        string _DisplayColor;
        public string DisplayColor
        {
            get => _DisplayColor;
            set
            {
                if (_DisplayColor != value)
                {
                    _DisplayColor = value;
                    RaisePropertyChanged("WindowUserName");
                }
            }
        }
        string _Resolution;
        public string Resolution
        {
            get => _Resolution;
            set
            {
                if (_Resolution != value)
                {
                    _Resolution = value;
                    RaisePropertyChanged("Resolution");
                }
            }
        }
        bool  _OnlineStatus;
        public bool OnlineStatus
        {
            get => _OnlineStatus;
            set
            {
                if (_OnlineStatus != value)
                {
                    _OnlineStatus = value;
                    RaisePropertyChanged("OnlineStatus");
                }
            }
        }
        string _LastLoginUser;
        public string LastLoginUser
        {
            get => _LastLoginUser;
            set
            {
                if (_LastLoginUser != value)
                {
                    _LastLoginUser = value;
                    RaisePropertyChanged("LastLoginUser");
                }
            }
        }
        bool _IsConsole;
        public bool IsConsole
        {
            get => _IsConsole;
            set
            {
                if (_IsConsole != value)
                {
                    _IsConsole = value;
                    RaisePropertyChanged("IsConsole");
                }
            }
        }

    }
}
