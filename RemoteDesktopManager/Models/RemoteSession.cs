using RemoteDesktopManager.Helpers;
using System.ComponentModel;

namespace RemoteDesktopManager.Models
{
    public class RemoteSession : Base.Session
    {
        long? _colorDepthId;
        RemoteDisplayColor _colorDepth;
        long? _sizeId;
        RemoteScreenSize _size;
        bool _isConsole = false;
        OnlineStatus? _status;

        public long? ColorDepthId
        {
            get => _colorDepthId;
            set { _colorDepthId = value; RaisePropertyChanged(); }
        }

        public RemoteDisplayColor ColorDepth
        {
            get => _colorDepth;
            set { _colorDepth = value; RaisePropertyChanged(); }
        }

        public long? SizeId
        {
            get => _sizeId;
            set { _sizeId = value; RaisePropertyChanged(); }
        }

        public RemoteScreenSize Size
        {
            get => _size;
            set { _size = value; RaisePropertyChanged(); }
        }

        [DefaultValue(false)]
        public bool IsConsole
        {
            get => _isConsole;
            set { _isConsole = value; RaisePropertyChanged(); }
        }

        public OnlineStatus? Status
        {
            get => _status;
            set { _status = value; RaisePropertyChanged(); }
        }
    }
}