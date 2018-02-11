using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RemoteDesktopManager.Helpers;

namespace RemoteDesktopManager.Models
{
    public class RemoteScreenSize : Base.Model
    {
        string _title;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual long Id { get; set; }

        public int? Width { get; set; }
        public int? Height { get; set; }

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