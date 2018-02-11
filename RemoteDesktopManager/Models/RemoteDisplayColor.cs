using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RemoteDesktopManager.Helpers;

namespace RemoteDesktopManager.Models
{
    public class RemoteDisplayColor : Base.Model
    {
       long _id;
        short _colorDepth;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual long Id
        {
            get => _id;
            set { _id = value; RaisePropertyChanged(); }
        }

        public short ColorDepth
        {
            get => _colorDepth;
            set { _colorDepth = value; RaisePropertyChanged(); }
        }

        public string Title => $"{ColorDepth} bits";
        
        public RemoteDisplayColor()
        {
        }

        public RemoteDisplayColor(DisplayColor value)
        {
            PrepareProperties(value);
        }

        void PrepareProperties(DisplayColor value)
        {
            Id = value.ToLong();
            var valueStr = value.ToString();
            ColorDepth = Convert.ToInt16(valueStr.Replace("_", "").Replace("bits", ""));
        }
    }
}