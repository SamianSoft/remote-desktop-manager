using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDesktopManager.Model
{
    public class OrgUnit : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

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
        string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
        int _OrgUnitParentId;
        public int OrgUnitParentId
        {
            get => _OrgUnitParentId;
            set
            {
                if (_OrgUnitParentId != value)
                {
                    _OrgUnitParentId = value;
                    RaisePropertyChanged("OrgUnitParentId");
                }
            }
        }
        string _Phone;
        public string Phone
        {
            get => _Phone;
            set
            {
                if (_Phone != value)
                {
                    _Phone = value;
                    RaisePropertyChanged("Phone");
                }
            }
        }
        string _Address;
        public string Address
        {
            get => _Address;
            set
            {
                if (_Address != value)
                {
                    _Address = value;
                    RaisePropertyChanged("Address");
                }
            }
        }
        string _Logo;
        public string Logo
        {
            get => _Logo;
            set
            {
                if (_Logo != value)
                {
                    _Logo = value;
                    RaisePropertyChanged("Logo");
                }
            }
        }
        string _CrmLink;
        public string CrmLink
        {
            get => _CrmLink;
            set
            {
                if (_CrmLink != value)
                {
                    _CrmLink = value;
                    RaisePropertyChanged("CrmLink");
                }
            }
        }
       
    }
}
