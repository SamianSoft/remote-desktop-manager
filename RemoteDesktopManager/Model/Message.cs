using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDesktopManager.Model
{
    class Message : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        int _MessageId;
        public int MessageId
        {
            get => _MessageId;
            set
            {
                if (_MessageId != value)
                {
                    _MessageId = value;
                    RaisePropertyChanged("MessageId");
                }
            }
        }
        string _FromUser;
        public string FromUser
        {
            get => _FromUser;
            set
            {
                if (_FromUser != value)
                {
                    _FromUser = value;
                    RaisePropertyChanged("FromUser");
                }
            }
        }
        string _ToUser;
        public string ToUser
        {
            get => _ToUser;
            set
            {
                if (_ToUser != value)
                {
                    _ToUser = value;
                    RaisePropertyChanged("ToUser");
                }
            }
        }
        string _MessageText;
        public string MessageText
        {
            get => _MessageText;
            set
            {
                if (_MessageText != value)
                {
                    _MessageText = value;
                    RaisePropertyChanged("MessageText");
                }
            }
        }
        DateTime _CreateTime;
        public DateTime CreateTime
        {
            get => _CreateTime;
            set
            {
                if (_CreateTime != value)
                {
                    _CreateTime = value;
                    RaisePropertyChanged("CreateTime");
                }
            }
        }
        bool _IsRead;
        public bool IsRead
        {
            get => _IsRead;
            set
            {
                if (_IsRead != value)
                {
                    _IsRead = value;
                    RaisePropertyChanged("IsRead");
                }
            }
        }
    }
}
