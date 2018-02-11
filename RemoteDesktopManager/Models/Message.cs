using System.ComponentModel.DataAnnotations;

namespace RemoteDesktopManager.Models
{
    public class Message : Base.Model
    {
        string _fromUser;
        string _toUser;
        bool _isRead;

        [Required]
        public string FromUser
        {
            get => _fromUser;
            set { _fromUser = value; RaisePropertyChanged(); }
        }

        [Required]
        public string ToUser
        {
            get => _toUser;
            set { _toUser = value; RaisePropertyChanged(); }
        }

        [Required]
        public bool IsRead
        {
            get => _isRead;
            set { _isRead = value; RaisePropertyChanged(); }
        }
    }
}