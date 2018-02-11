using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RemoteDesktopManager.Helpers;

namespace RemoteDesktopManager.Models
{
    public class RemoteScreenSize : Base.Model
    {
        string _title;
        long _id;
        int? _width;
        int? _height;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual long Id
        {
            get => _id;
            set { _id = value; RaisePropertyChanged(); }
        }

        public int? Width
        {
            get => _width;
            set { _width = value; RaisePropertyChanged(); }
        }

        public int? Height
        {
            get => _height;
            set { _height = value; RaisePropertyChanged(); }
        }

        public string Title
        {
            get => string.IsNullOrEmpty(_title) ? $"{Width}x{Height}" : _title;
            set => _title = value;
        }

        public RemoteScreenSize()
        {
        }

        public RemoteScreenSize(ScreenSize value)
        {
            PrepareProperties(value);
        }

        void PrepareProperties(ScreenSize value)
        {
            Id = value.ToLong();
            var valueStr = value.ToString();
            var splitedValue = valueStr.Split('_');
            Width = Convert.ToInt32(splitedValue[0].Replace("W", ""));
            Height = Convert.ToInt32(splitedValue[1].Replace("H", ""));
        }
    }
}