using System;
using System.ComponentModel.DataAnnotations;
using RemoteDesktopManager.Models.Base;

namespace RemoteDesktopManager.Models
{
    public class SessionLog : Base.Model
    {
        string _user;
        string _localIp;
        DateTimeOffset _connectTime = DateTimeOffset.Now;
        DateTimeOffset? _disconnectTime;
        long? _sessionId;
        Session _session;

        [Required]
        public string User
        {
            get => _user;
            set { _user = value; RaisePropertyChanged(); }
        }

        [Required]
        public string LocalIp
        {
            get => _localIp;
            set { _localIp = value; RaisePropertyChanged(); }
        }

        [Required]
        public DateTimeOffset ConnectTime
        {
            get => _connectTime;
            set { _connectTime = value; RaisePropertyChanged(); }
        }

        public DateTimeOffset? DisconnectTime
        {
            get => _disconnectTime;
            set { _disconnectTime = value; RaisePropertyChanged(); }
        }

        public long? SessionId
        {
            get => _sessionId;
            set { _sessionId = value; RaisePropertyChanged(); }
        }

        public Base.Session Session
        {
            get => _session;
            set { _session = value; RaisePropertyChanged(); }
        }
    }
}