using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace RemoteDesktopManager.Models.Base
{
    public abstract class Model : INotifyPropertyChanged
    {
        long _id;
        DateTimeOffset _creteDate = DateTimeOffset.Now;
        DateTimeOffset _updateDate = DateTimeOffset.Now;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual long Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged();
            }
        }

        public DateTimeOffset CreteDate
        {
            get => _creteDate;
            set
            {
                _creteDate = value;
                RaisePropertyChanged();
            }
        }

        public DateTimeOffset UpdateDate
        {
            get => _updateDate;
            set
            {
                _updateDate = value;
                RaisePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}