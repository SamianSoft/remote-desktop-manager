using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RemoteDesktopManager.Models.Base
{
    public abstract class Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual long Id { get; set; }

        [Required]
        public DateTimeOffset CreteDate { get; set; } = DateTimeOffset.Now;

        [Required]
        public DateTimeOffset UpdateDate { get; set; } = DateTimeOffset.Now;
    }
}